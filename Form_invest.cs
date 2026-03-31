using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Semillero
{
    public partial class Form_invest : Form
    {
        public int idSemillero; // creamos la variable idSemillero para almacenar el id del semillero al que pertenece el investigador
        public Form_invest(int idSemillero)
        {
            InitializeComponent();
            this.idSemillero = idSemillero;
        }
    }
}
