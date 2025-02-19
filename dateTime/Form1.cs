namespace dateTime
{
    public partial class frmDataTime : Form
    {
        public frmDataTime()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaCalculo.Enabled = true;
            btnCalcular.Enabled = true;
            dtpFechaCalculo.MinDate = dtpFechaNacimiento.Value;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = dtpFechaNacimiento.Value;
            DateTime calculo = dtpFechaCalculo.Value;

            int edad = calculo.Year - nacimiento.Year;
            int meses = calculo.Month - nacimiento.Month;
            int dias = calculo.Day - nacimiento.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(nacimiento.Year, nacimiento.Month);
            }

            if (meses < 0)
            {
                edad--;
                meses += 12;
            }


            MessageBox.Show(" Años: " + edad + " Meses: " + meses + " Días: " + dias, "Calculo de Edad",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCurp_Click(object sender, EventArgs e)
        {
            string fecha = txtboxCurp.Text.Substring(4, 6);
            string sexo = txtboxCurp.Text.Substring(10, 1);
            string estado = txtboxCurp.Text.Substring(11, 2);
            DateTime fechaNacimiento = FormatearFecha(fecha);
            int edad = CalcularEdad(fechaNacimiento);

            MessageBox.Show("Edad: " + edad + "  Sexo: " + ObtenerSexo(sexo) + "  Estado: " + ObtenerNombreEstado(estado), "Datos de la CURP",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string ObtenerNombreEstado(string clave)
        {
            switch (clave)
            {
                case "AS":
                    return "Aguascalientes";
                case "BC":
                    return "Baja California";
                case "BS":
                    return "Baja California Sur";
                case "CC":
                    return "Campeche";
                case "CS":
                    return "Chiapas";
                case "CH":
                    return "Chihuahua";
                case "DF":
                    return "Ciudad de México";
                case "CL":
                    return "Coahuila";
                case "CM":
                    return "Colima";
                case "DG":
                    return "Durango";
                case "GT":
                    return "Guanajuato";
                case "GR":
                    return "Guerrero";
                case "HG":
                    return "Hidalgo";
                case "JC":
                    return "Jalisco";
                case "MC":
                    return "México";
                case "MN":
                    return "Michoacán";
                case "MS":
                    return "Morelos";
                case "NT":
                    return "Nayarit";
                case "NL":
                    return "Nuevo León";
                case "OC":
                    return "Oaxaca";
                case "PL":
                    return "Puebla";
                case "QO":
                    return "Querétaro";
                case "QR":
                    return "Quintana Roo";
                case "SP":
                    return "San Luis Potosí";
                case "SL":
                    return "Sinaloa";
                case "SR":
                    return "Sonora";
                case "TC":
                    return "Tabasco";
                case "TS":
                    return "Tamaulipas";
                case "TL":
                    return "Tlaxcala";
                case "VZ":
                    return "Veracruz";
                case "YN":
                    return "Yucatán";
                case "ZS":
                    return "Zacatecas";
                default:
                    return "Clave desconocida";
            }
        }

        private string ObtenerSexo(string clave)
        {
            switch (clave)
            {
                case "H":
                    return "Hombre";
                case "M":
                    return "Mujer";
                default:
                    return "Clave desconocida";
            }
        }

        public DateTime FormatearFecha(string fecha)
        {
            if (fecha.Length != 6)
                throw new ArgumentException("La fecha debe tener exactamente 6 caracteres.");

            int year = int.Parse(fecha.Substring(0, 2));
            int month = int.Parse(fecha.Substring(2, 2));
            int day = int.Parse(fecha.Substring(4, 2));

            // Asumiendo que si el año es mayor o igual a 30 es del siglo XX, de lo contrario es del siglo XXI
            year = (year >= 30) ? (1900 + year) : (2000 + year);

            return new DateTime(year, month, day);
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        private void txtboxCurp_TextChanged(object sender, EventArgs e)
        {
            btnCurp.Enabled = (txtboxCurp.Text.Length == 18);
        }
    }
}    
