using Renta_de_Video_2._0.Clases;
using System;
using System.Windows.Forms;

namespace Renta_de_Video_2._0
{
  public partial class Lista_Facturas : Form
  {
    public Lista_Facturas()
    {
      InitializeComponent();
      this.FormBorderStyle = FormBorderStyle.None;
    }

    private void porcliente_TextChanged(object sender, EventArgs e) { }

    // Inicio de código de "Andy Alfonso Garcia Lopez" con carné: "9959-23-1494" en la fecha de: "31/07/2026"
    private void OnBuscar_Click(object sender, EventArgs e) {

      try{
     
        if (string.IsNullOrWhiteSpace(txt_porcliente.Text))
          throw new Exception("Ingresa el código de membresía del cliente.");

        string sCodigo = txt_porcliente.Text.Trim().ToUpper();
        string sNumero = sCodigo.Replace("MEM-", "");
        int iIdMembresia = int.Parse(sNumero);

           Cfacturas objFacturas = new Cfacturas();
           objFacturas.mostrarFacturas(dgv_facturas, iIdMembresia);
           MessageBox.Show("Búsqueda de cliente realizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
        catch (FormatException) {
           MessageBox.Show("El código debe tener el formato MEM-0000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex){
       
         MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
}

    private void OnVerDetalle_Click(object sender, EventArgs e) {
      try {
        
         if (dgv_facturas.SelectedRows.Count == 0)
         throw new Exception("Selecciona una factura de la tabla para ver el detalle.");
                
         Form menuPrincipal = Application.OpenForms["menu"];
         if (menuPrincipal is menu formMenu)  {
            formMenu.AbrirFormInPanel(new Detalle_De_Factura());
                
         }
      }
           
        catch (Exception ex) {
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void Lista_Facturas_Load(object sender, EventArgs e)
    {}

    private void pictureBox1_Click(object sender, EventArgs e)
    {}

    private void OnSalir_Click(object sender, EventArgs e) {
    
       Application.Exit();
    }
     // Fin de código de "Andy Alfonso Garcia Lopez" con carné: "9959-23-1494" en la fecha de: "31/07/2026"
    }
}