using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jistem_Analyser.NavigationControl
{
    public partial class ucTeste : UserControl
    {
        public ucTeste()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            int[] sizes = { 1000, 10000, 100000, 1000000, 10000000, 50000000, 100000000};
            int repetitions = 5;

            progressBar.Maximum = sizes.Length;
            progressBar.Value = 0;

            labelStatus.Text = "Teste em progresso...";

            StringBuilder detailedResults = new StringBuilder();

            foreach (var size in sizes)
            {
                labelArraySize.Text = $"Tamanho do array: {size}";

                long totalWriteTime = 0;
                long totalReadTime = 0;

                for (int i = 0; i < repetitions; i++)
                {
                    // Teste de escrita
                    totalWriteTime += await Task.Run(() => TestWritePerformance(size));

                    // Teste de leitura
                    totalReadTime += await Task.Run(() => TestReadPerformance(size));
                }

                long averageWriteTime = totalWriteTime / repetitions;
                long averageReadTime = totalReadTime / repetitions;

                labelWriteTime.Text = $"Tempo médio de escrita para array de tamanho {size}: {averageWriteTime} ms";
                labelReadTime.Text = $"Tempo médio de leitura para array de tamanho {size}: {averageReadTime} ms";

                detailedResults.AppendLine($"Array de tamanho {size}:");
                detailedResults.AppendLine($" - Tempo médio de escrita: {averageWriteTime} ms");
                detailedResults.AppendLine($" - Tempo médio de leitura: {averageReadTime} ms");
                detailedResults.AppendLine();

                progressBar.Value++;
                await Task.Delay(500); // Adicione um pequeno atraso para visualizar a progressão
            }

            labelStatus.Text = "Concluído";
            MessageBox.Show(detailedResults.ToString(), "Resultados Detalhados");
        }

        private long TestWritePerformance(int size)
        {
            int[] array = new int[size];
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }
            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        private long TestReadPerformance(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }

            Stopwatch stopwatch = new Stopwatch();

            int sum = 0;
            stopwatch.Start();
            for (int i = 0; i < size; i++)
            {
                sum += array[i];
            }
            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }
    }
}
