using AppTitlesAnime.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContext = AppTitlesAnime.Models.AppContext;

namespace AppTitlesAnime
{
    public partial class FormListTypes : Form
    {
        private AppContext db;

        public FormListTypes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Types.Load();
            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();

            // скрытие столбцов
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTitles"].Visible = false;

            // изменение названий заголовков столбцов
            dataGridViewTypes.Columns["TypeName"].HeaderText = "Тип аниме";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            FormAddType formAddType = new FormAddType();
            formAddType.ShowDialog();
        }

        private void FormListTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
