using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelperTxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionaTxt;
            selecionaTxt = new OpenFileDialog()
            {
                FileName = "",
                Filter = "Arquivo de texto (*.txt)|*.txt",
                Title = "Selecione o txt "
            };


            

            if (selecionaTxt.ShowDialog() == DialogResult.OK)
            {
                string filePatch = selecionaTxt.FileName;
                if (File.Exists(filePatch))
                {

                    try
                    {
                        using (StreamReader sr = new StreamReader(filePatch))
                        {

                            int qtdLinhas = File.ReadLines(filePatch).Count();
                            //MessageBox.Show(qtdLinhas.ToString());

                            string[] dadosTxt;
                            dadosTxt = new string[qtdLinhas];

                            for (int i = 0; i < qtdLinhas; i++)
                            {
                                //Console.WriteLine(sr.ReadLine());
                              

                                dadosTxt[i] = sr.ReadLine();

                                

                            }

                            for(int i = 0; i < dadosTxt.Length; i++)
                            {
                             
                                MessageBox.Show(dadosTxt[i]);
                            }
                        
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }
        }
    }
}
