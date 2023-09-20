using System;
using System.Windows.Forms;

namespace FormComplejos_G2_2024_1
{
    public partial class Form1 : Form
    {
        Complejo c1;
        Complejo c2;
        Complejo c3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbReal1.Text == "" )
                {
                    throw new ApplicationException("La parte real del complejo 1 no debe estar vacía. ");
                }
                else
                {
                    errorProvider1.Clear();
                }
                if (txtbReal2.Text == "")
                {
                    throw new ApplicationException("La parte real del complejo 2 no debe estar vacía. ");
                }
                else
                {
                    errorProvider3.Clear();
                }
                if (txtbImaginario1.Text == "")
                {
                    throw new ApplicationException("La parte imaginaria del complejo 1 no debe estar vacía. ");
                }
                else
                {
                    errorProvider2.Clear();
                }
                if (txtbImagnario2.Text == "")
                {
                    throw new ApplicationException("La parte imaginaria del complejo 2 no debe estar vacía. ");
                }
                else
                {
                    errorProvider4.Clear();
                }

                c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginario1.Text));
                c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImagnario2.Text));

                c3 = c1 + c2;
                lbSuma.Text = c3.ToString();
                errorProvider1.Clear();
            }
            catch (ApplicationException error)
            {
                if (txtbReal1.Text == "")
                {
                    errorProvider1.SetError(txtbReal1, error.Message);
                }
                if (txtbReal2.Text == "")
                {
                    errorProvider3.SetError(txtbReal2, error.Message);
                }
                if (txtbImaginario1.Text == "")
                {
                    errorProvider2.SetError(txtbImaginario1, error.Message);
                }
                if (txtbImagnario2.Text == "")
                {
                    errorProvider4.SetError(txtbImagnario2, error.Message);
                }
            }

            catch (FormatException error) 
            {
                MessageBox.Show("Error: Debes de ingresar un número");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }

        }
        private void btnConjugar_Click(object sender, EventArgs e)
        {
            lbSuma.Text = (~c3).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbReal1.Text == "")
                {
                    throw new ApplicationException("La parte real del complejo 1 no debe estar vacía. ");
                }
                else
                {
                    errorProvider1.Clear();
                }
                if (txtbReal2.Text == "")
                {
                    throw new ApplicationException("La parte real del complejo 2 no debe estar vacía. ");
                }
                else
                {
                    errorProvider3.Clear();
                }
                if (txtbImaginario1.Text == "")
                {
                    throw new ApplicationException("La parte imaginaria del complejo 1 no debe estar vacía. ");
                }
                else
                {
                    errorProvider2.Clear();
                }
                if (txtbImagnario2.Text == "")
                {
                    throw new ApplicationException("La parte imaginaria del complejo 2 no debe estar vacía. ");
                }
                else
                {
                    errorProvider4.Clear();
                }

                c3 = c1 * c2;
                lbSuma.Text = c3.ToString();
            }
            catch (ApplicationException error)
            {
                if (txtbReal1.Text == "")
                {
                    errorProvider1.SetError(txtbReal1, error.Message);
                }
                if (txtbReal2.Text == "")
                {
                    errorProvider2.SetError(txtbReal2, error.Message);
                }
                if (txtbImaginario1.Text == "")
                {
                    errorProvider3.SetError(txtbImaginario1, error.Message);

                }
                if (txtbImagnario2.Text == "")
                {
                    errorProvider4.SetError(txtbImagnario2, error.Message);

                }
            }

            catch (FormatException error)
            {
                MessageBox.Show("Error: Debes de ingresar un número");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            c3 = c1 - c2;
            lbSuma.Text = c3.ToString();
        }
    }
}
