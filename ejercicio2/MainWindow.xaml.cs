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
            string cliente = txtCliente.Text;
            double deuda = double.Parse(txtDeuda.Text);

            double montoDescuento = 0;
            double montoBonus = 0;

            if (chkDescuento.IsChecked == true)
            {
                double porcentaje = double.Parse(txtDescuento.Text);
                montoDescuento = deuda * (porcentaje / 100);
            }

            if (chkBonus.IsChecked == true)
            {
                double puntos = double.Parse(txtBonus.Text);
                montoBonus = (puntos / 10) * 3;
            }

            double nuevaDeuda = deuda - (montoDescuento + montoBonus);

            lblDescuento.Text = $"Descuento obtenido: S/ {montoDescuento:F2}";
            lblBonus.Text = $"Monto pagado por P. Bonus: S/ {montoBonus:F2}";
            lblNuevaDeuda.Text = $"Total a Pagar (Nueva deuda): S/ {nuevaDeuda:F2}";
        }
    }
}