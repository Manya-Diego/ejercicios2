using System;
using System.Windows;

namespace WpfApplication1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            string personal = txtPersonal.Text;
            string codigo = txtCodigo.Text;
            double ingreso = double.Parse(txtIngreso.Text);

            double fonavi = 0;
            double renta = 0;
            double afp = 0;

            if (chkFonavi.IsChecked == true)
            {
                fonavi = ingreso * 0.08;
            }

            if (chkRenta.IsChecked == true)
            {
                renta = ingreso * 0.05;
            }

            if (chkAfp.IsChecked == true)
            {
                afp = ingreso * 0.12;
            }

            double totalPagar = ingreso - (fonavi + renta + afp);

            lblFonavi.Text = $"Fonavi: {fonavi:F2}";
            lblRenta.Text = $"Imp. Renta: {renta:F2}";
            lblAfp.Text = $"A.F.P.: {afp:F2}";
            lblTotal.Text = $"Total a Pagar: {totalPagar:F2}";
        }
    }
}