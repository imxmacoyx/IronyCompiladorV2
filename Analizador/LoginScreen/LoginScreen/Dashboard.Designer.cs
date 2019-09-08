namespace MACOY
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelCodigo = new System.Windows.Forms.Panel();
            this.tabContenedor = new System.Windows.Forms.TabControl();
            this.tabCodigo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.RichTextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panelTokens = new System.Windows.Forms.Panel();
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOpen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panelErrores = new System.Windows.Forms.Panel();
            this.lblerror = new System.Windows.Forms.Label();
            this.tokens = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picCerrarListaDeErrores = new System.Windows.Forms.PictureBox();
            this.dgvListaDeErrores = new System.Windows.Forms.DataGridView();
            this.TokenError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LexemaError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineaError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.OpenFileDialog();
            this.Save = new System.Windows.Forms.SaveFileDialog();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelContenedor.SuspendLayout();
            this.panelCodigo.SuspendLayout();
            this.tabContenedor.SuspendLayout();
            this.tabCodigo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelTokens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panelErrores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrarListaDeErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelCodigo);
            this.panelContenedor.Controls.Add(this.panelTokens);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelErrores);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1264, 560);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelCodigo
            // 
            this.panelCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.panelCodigo.Controls.Add(this.tabContenedor);
            this.panelCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCodigo.Location = new System.Drawing.Point(0, 50);
            this.panelCodigo.Name = "panelCodigo";
            this.panelCodigo.Size = new System.Drawing.Size(1014, 371);
            this.panelCodigo.TabIndex = 0;
            // 
            // tabContenedor
            // 
            this.tabContenedor.Controls.Add(this.tabCodigo);
            this.tabContenedor.Controls.Add(this.tabPage1);
            this.tabContenedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContenedor.Font = new System.Drawing.Font("Lato Thin", 12F);
            this.tabContenedor.Location = new System.Drawing.Point(0, 0);
            this.tabContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.tabContenedor.Name = "tabContenedor";
            this.tabContenedor.Padding = new System.Drawing.Point(3, 3);
            this.tabContenedor.SelectedIndex = 0;
            this.tabContenedor.Size = new System.Drawing.Size(1014, 371);
            this.tabContenedor.TabIndex = 0;
            // 
            // tabCodigo
            // 
            this.tabCodigo.BackColor = System.Drawing.Color.White;
            this.tabCodigo.Controls.Add(this.panel1);
            this.tabCodigo.Controls.Add(this.pictureBox8);
            this.tabCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabCodigo.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCodigo.ForeColor = System.Drawing.Color.White;
            this.tabCodigo.Location = new System.Drawing.Point(4, 28);
            this.tabCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.tabCodigo.Name = "tabCodigo";
            this.tabCodigo.Size = new System.Drawing.Size(1006, 339);
            this.tabCodigo.TabIndex = 0;
            this.tabCodigo.Text = "Código";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(51, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 339);
            this.panel1.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.CausesValidation = false;
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigo.Location = new System.Drawing.Point(0, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(955, 339);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "public class Script{\n/*\npublic static void main(String []args){\nSystem.out.printl" +
    "n(\"Hello world!\");\n}\n*/\n}";
            this.txtCodigo.Click += new System.EventHandler(this.TxtCodigo_Click);
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(51, 339);
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox7);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1006, 339);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Arbol";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1006, 339);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // panelTokens
            // 
            this.panelTokens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelTokens.Controls.Add(this.dgvTokens);
            this.panelTokens.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTokens.Location = new System.Drawing.Point(1014, 50);
            this.panelTokens.Name = "panelTokens";
            this.panelTokens.Size = new System.Drawing.Size(250, 371);
            this.panelTokens.TabIndex = 3;
            // 
            // dgvTokens
            // 
            this.dgvTokens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTokens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTokens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Lexema,
            this.Fila});
            this.dgvTokens.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvTokens.Location = new System.Drawing.Point(9, 0);
            this.dgvTokens.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dgvTokens.Name = "dgvTokens";
            this.dgvTokens.ReadOnly = true;
            this.dgvTokens.RowHeadersVisible = false;
            this.dgvTokens.Size = new System.Drawing.Size(241, 371);
            this.dgvTokens.TabIndex = 2;
            this.dgvTokens.TabStop = false;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            this.Lexema.ReadOnly = true;
            // 
            // Fila
            // 
            this.Fila.HeaderText = "Fila";
            this.Fila.Name = "Fila";
            this.Fila.ReadOnly = true;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelMenu.Controls.Add(this.flowLayoutPanel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1264, 50);
            this.panelMenu.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.btnOpen);
            this.flowLayoutPanel1.Controls.Add(this.bunifuFlatButton1);
            this.flowLayoutPanel1.Controls.Add(this.bunifuFlatButton6);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.bunifuFlatButton2);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.bunifuFlatButton3);
            this.flowLayoutPanel1.Controls.Add(this.bunifuFlatButton4);
            this.flowLayoutPanel1.Controls.Add(this.bunifuFlatButton5);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Controls.Add(this.bunifuFlatButton7);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1264, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.BorderRadius = 0;
            this.btnNew.ButtonText = "New Script";
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.DisabledColor = System.Drawing.Color.Transparent;
            this.btnNew.Font = new System.Drawing.Font("Lato Thin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNew.Iconimage = global::MACOY.Properties.Resources.icons8_Code_File_100px_1;
            this.btnNew.Iconimage_right = null;
            this.btnNew.Iconimage_right_Selected = null;
            this.btnNew.Iconimage_Selected = null;
            this.btnNew.IconMarginLeft = 0;
            this.btnNew.IconMarginRight = 0;
            this.btnNew.IconRightVisible = true;
            this.btnNew.IconRightZoom = 0D;
            this.btnNew.IconVisible = true;
            this.btnNew.IconZoom = 60D;
            this.btnNew.IsTab = false;
            this.btnNew.Location = new System.Drawing.Point(3, 4);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNew.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.btnNew.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNew.selected = false;
            this.btnNew.Size = new System.Drawing.Size(133, 44);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Script";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Textcolor = System.Drawing.Color.White;
            this.btnNew.TextFont = new System.Drawing.Font("Lato Thin", 9.749999F);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.BorderRadius = 0;
            this.btnOpen.ButtonText = "Open Script";
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.DisabledColor = System.Drawing.Color.Transparent;
            this.btnOpen.Font = new System.Drawing.Font("Lato Thin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOpen.Iconimage = global::MACOY.Properties.Resources.icons8_Open_in_Browser_100px;
            this.btnOpen.Iconimage_right = null;
            this.btnOpen.Iconimage_right_Selected = null;
            this.btnOpen.Iconimage_Selected = null;
            this.btnOpen.IconMarginLeft = 0;
            this.btnOpen.IconMarginRight = 0;
            this.btnOpen.IconRightVisible = true;
            this.btnOpen.IconRightZoom = 0D;
            this.btnOpen.IconVisible = true;
            this.btnOpen.IconZoom = 60D;
            this.btnOpen.IsTab = false;
            this.btnOpen.Location = new System.Drawing.Point(142, 4);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Normalcolor = System.Drawing.Color.Transparent;
            this.btnOpen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.btnOpen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOpen.selected = false;
            this.btnOpen.Size = new System.Drawing.Size(133, 44);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open Script";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOpen.Textcolor = System.Drawing.Color.White;
            this.btnOpen.TextFont = new System.Drawing.Font("Lato Thin", 9.749999F);
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Close Script";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Lato Thin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::MACOY.Properties.Resources.icons8_Close_Program_100px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(281, 4);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(133, 44);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "Close Script";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Lato Thin", 9.749999F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Save Script";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Font = new System.Drawing.Font("Lato Thin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = global::MACOY.Properties.Resources.icons8_Save_100px;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 60D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(420, 4);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(133, 44);
            this.bunifuFlatButton6.TabIndex = 9;
            this.bunifuFlatButton6.Text = "Save Script";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Lato Thin", 9.749999F);
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MACOY.Properties.Resources.icons8_Thick_Vertical_Line_100px;
            this.pictureBox1.Location = new System.Drawing.Point(559, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Execute";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Lato Thin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::MACOY.Properties.Resources.icons8_Command_Line_100px;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 60D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(575, 4);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(133, 44);
            this.bunifuFlatButton2.TabIndex = 4;
            this.bunifuFlatButton2.Text = "Execute";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Lato Thin", 9.749999F);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MACOY.Properties.Resources.icons8_Thick_Vertical_Line_100px;
            this.pictureBox2.Location = new System.Drawing.Point(714, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Lato Thin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::MACOY.Properties.Resources.icons8_Zoom_In_100px;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 60D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(730, 4);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(44, 44);
            this.bunifuFlatButton3.TabIndex = 6;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Lato Thin", 9.749999F);
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("Lato Thin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::MACOY.Properties.Resources.icons8_Zoom_Out_100px;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 60D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(780, 4);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(44, 44);
            this.bunifuFlatButton4.TabIndex = 7;
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Lato Thin", 9.749999F);
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Font = new System.Drawing.Font("Lato Thin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::MACOY.Properties.Resources.icons8_Zoom_to_Actual_Size_100px;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 60D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(830, 4);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(44, 44);
            this.bunifuFlatButton5.TabIndex = 8;
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Lato Thin", 9.749999F);
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MACOY.Properties.Resources.icons8_Thick_Vertical_Line_100px;
            this.pictureBox3.Location = new System.Drawing.Point(880, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Font = new System.Drawing.Font("Lato Thin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = global::MACOY.Properties.Resources.icons8_Flow_Chart_100px;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 60D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(896, 4);
            this.bunifuFlatButton7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(44, 44);
            this.bunifuFlatButton7.TabIndex = 11;
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Lato Thin", 9.749999F);
            this.bunifuFlatButton7.Click += new System.EventHandler(this.bunifuFlatButton7_Click_1);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(946, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(88, 69);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // panelErrores
            // 
            this.panelErrores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelErrores.Controls.Add(this.lblerror);
            this.panelErrores.Controls.Add(this.tokens);
            this.panelErrores.Controls.Add(this.pictureBox5);
            this.panelErrores.Controls.Add(this.pictureBox4);
            this.panelErrores.Controls.Add(this.picCerrarListaDeErrores);
            this.panelErrores.Controls.Add(this.dgvListaDeErrores);
            this.panelErrores.Controls.Add(this.label1);
            this.panelErrores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelErrores.Location = new System.Drawing.Point(0, 421);
            this.panelErrores.Name = "panelErrores";
            this.panelErrores.Size = new System.Drawing.Size(1264, 139);
            this.panelErrores.TabIndex = 2;
            // 
            // lblerror
            // 
            this.lblerror.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.White;
            this.lblerror.Location = new System.Drawing.Point(1231, 0);
            this.lblerror.Margin = new System.Windows.Forms.Padding(0);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(18, 19);
            this.lblerror.TabIndex = 6;
            this.lblerror.Text = "0";
            // 
            // tokens
            // 
            this.tokens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tokens.AutoSize = true;
            this.tokens.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokens.ForeColor = System.Drawing.Color.White;
            this.tokens.Location = new System.Drawing.Point(1121, 0);
            this.tokens.Margin = new System.Windows.Forms.Padding(0);
            this.tokens.Name = "tokens";
            this.tokens.Size = new System.Drawing.Size(18, 19);
            this.tokens.TabIndex = 5;
            this.tokens.Text = "0";
            this.tokens.Click += new System.EventHandler(this.tokens_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::MACOY.Properties.Resources.icons8_Error_100px_1;
            this.pictureBox5.Location = new System.Drawing.Point(1208, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::MACOY.Properties.Resources.icons8_Average_2_100px;
            this.pictureBox4.Location = new System.Drawing.Point(1098, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // picCerrarListaDeErrores
            // 
            this.picCerrarListaDeErrores.Image = global::MACOY.Properties.Resources.icons8_Drop_Down_50px;
            this.picCerrarListaDeErrores.Location = new System.Drawing.Point(116, 2);
            this.picCerrarListaDeErrores.Name = "picCerrarListaDeErrores";
            this.picCerrarListaDeErrores.Size = new System.Drawing.Size(20, 20);
            this.picCerrarListaDeErrores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrarListaDeErrores.TabIndex = 2;
            this.picCerrarListaDeErrores.TabStop = false;
            this.picCerrarListaDeErrores.Click += new System.EventHandler(this.picCerrarListaDeErrores_Click);
            // 
            // dgvListaDeErrores
            // 
            this.dgvListaDeErrores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaDeErrores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListaDeErrores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.dgvListaDeErrores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaDeErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TokenError,
            this.LexemaError,
            this.LineaError});
            this.dgvListaDeErrores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvListaDeErrores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListaDeErrores.Location = new System.Drawing.Point(0, 25);
            this.dgvListaDeErrores.MultiSelect = false;
            this.dgvListaDeErrores.Name = "dgvListaDeErrores";
            this.dgvListaDeErrores.ReadOnly = true;
            this.dgvListaDeErrores.RowHeadersVisible = false;
            this.dgvListaDeErrores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvListaDeErrores.Size = new System.Drawing.Size(1264, 114);
            this.dgvListaDeErrores.TabIndex = 1;
            this.dgvListaDeErrores.TabStop = false;
            // 
            // TokenError
            // 
            this.TokenError.HeaderText = "Token";
            this.TokenError.Name = "TokenError";
            this.TokenError.ReadOnly = true;
            // 
            // LexemaError
            // 
            this.LexemaError.HeaderText = "Lexema";
            this.LexemaError.Name = "LexemaError";
            this.LexemaError.ReadOnly = true;
            // 
            // LineaError
            // 
            this.LineaError.HeaderText = "Linea";
            this.LineaError.Name = "LineaError";
            this.LineaError.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de errores";
            // 
            // Open
            // 
            this.Open.FileName = "openFileDialog1";
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 560);
            this.Controls.Add(this.panelContenedor);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelContenedor.ResumeLayout(false);
            this.panelCodigo.ResumeLayout(false);
            this.tabContenedor.ResumeLayout(false);
            this.tabCodigo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelTokens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panelErrores.ResumeLayout(false);
            this.panelErrores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrarListaDeErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelTokens;
        private System.Windows.Forms.Panel panelErrores;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTokens;
        private System.Windows.Forms.DataGridView dgvListaDeErrores;
        private System.Windows.Forms.Panel panelCodigo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnNew;
        private Bunifu.Framework.UI.BunifuFlatButton btnOpen;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private System.Windows.Forms.TabControl tabContenedor;
        private System.Windows.Forms.TabPage tabCodigo;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private System.Windows.Forms.OpenFileDialog Open;
        private System.Windows.Forms.SaveFileDialog Save;
        private System.Windows.Forms.PictureBox picCerrarListaDeErrores;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label tokens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn TokenError;
        private System.Windows.Forms.DataGridViewTextBoxColumn LexemaError;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineaError;
        public System.Windows.Forms.RichTextBox txtCodigo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}