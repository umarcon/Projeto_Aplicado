using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace gestao_condominio.Forms
{
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mesDe = string.Empty;
            var diaDe = string.Empty;
            var mesAte = string.Empty;
            var diaAte = string.Empty;
            
            var dataDe = dtDeVisitante.Value;
            var dataAte = dtAteVisitante.Value;

            if (dataDe.Month.ToString().Length == 1)
            {
                mesDe = "0" + dataDe.Month;
            }
            else
            {
                mesDe = dataDe.Month.ToString();
            }

            if (dataDe.Day.ToString().Length == 1)
            {
                diaDe = "0" + dataDe.Day;
            }
            else
            {
                diaDe = dataDe.Day.ToString();
            }

            if (dataAte.Month.ToString().Length == 1)
            {
                mesAte = "0" + dataAte.Month;
            }
            else
            {
                mesAte = dataAte.Month.ToString();
            }

            if (dataAte.Day.ToString().Length == 1)
            {
                diaAte = "0" + dataAte.Day;
            }
            else
            {
                diaAte = dataAte.Day.ToString();
            }

            var strDe = dataDe.Year + "-" + mesDe + "-" + diaDe;
            var strAte = dataAte.Year + "-" + mesAte + "-" + diaAte;

            var listExport = SqlUtils.GetVisitantes(strDe, strAte);

            if (listExport.Count > 0)
            {
                try
                {
                    // Inicia o componente Excel
                    Excel.Application xlApp;
                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    //Cria uma planilha temporária na memória do computador
                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    //incluindo dados
                    xlWorkSheet.Cells[1, 1] = "Morador";
                    xlWorkSheet.Cells[1, 2] = "Visitante";
                    xlWorkSheet.Cells[1, 3] = "Data Visita";
                    xlWorkSheet.Cells[1, 4] = "RG";

                    for (int i = 0; i < listExport.Count; i++)
                    {
                        var l = i + 2;
                        xlWorkSheet.Cells[l, 1] = "Ulisses Marcon";
                        xlWorkSheet.Cells[l, 2] = listExport[i].nome;
                        xlWorkSheet.Cells[l, 3] = listExport[i].data_visita;
                        xlWorkSheet.Cells[l, 4] = listExport[i].rg;
                    }

                    //Salva o arquivo de acordo com a documentação do Excel.
                    xlWorkBook.SaveAs(@"C:\Relatorios\Visitantes_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                    Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    MessageBox.Show("Arquivo gerado com êxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var mesDe = string.Empty;
            var diaDe = string.Empty;
            var mesAte = string.Empty;
            var diaAte = string.Empty;

            var dataDe = dtDeLocacoes.Value;
            var dataAte = dtAteLocacoes.Value;

            if (dataDe.Month.ToString().Length == 1)
            {
                mesDe = "0" + dataDe.Month;
            }
            else
            {
                mesDe = dataDe.Month.ToString();
            }

            if (dataDe.Day.ToString().Length == 1)
            {
                diaDe = "0" + dataDe.Day;
            }
            else
            {
                diaDe = dataDe.Day.ToString();
            }

            if (dataAte.Month.ToString().Length == 1)
            {
                mesAte = "0" + dataAte.Month;
            }
            else
            {
                mesAte = dataAte.Month.ToString();
            }

            if (dataAte.Day.ToString().Length == 1)
            {
                diaAte = "0" + dataAte.Day;
            }
            else
            {
                diaAte = dataAte.Day.ToString();
            }

            var strDe = dataDe.Year + "-" + mesDe + "-" + diaDe;
            var strAte = dataAte.Year + "-" + mesAte + "-" + diaAte;

            var listExport = SqlUtils.GetEventos(strDe, strAte);

            if (listExport.Count > 0)
            {
                try
                {
                    // Inicia o componente Excel
                    Excel.Application xlApp;
                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    //Cria uma planilha temporária na memória do computador
                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    //incluindo dados
                    xlWorkSheet.Cells[1, 1] = "Morador";
                    xlWorkSheet.Cells[1, 2] = "Evento";
                    xlWorkSheet.Cells[1, 3] = "Data";

                    for (int i = 0; i < listExport.Count; i++)
                    {
                        var l = i + 2;
                        xlWorkSheet.Cells[l, 1] = "Ulisses Marcon";
                        xlWorkSheet.Cells[l, 2] = "Churrasqueira";
                        xlWorkSheet.Cells[l, 3] = listExport[i].data;
                    }

                    //Salva o arquivo de acordo com a documentação do Excel.
                    xlWorkBook.SaveAs(@"C:\Relatorios\Eventos_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                    Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    MessageBox.Show("Arquivo gerado com êxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
            }
        }
    }
}
