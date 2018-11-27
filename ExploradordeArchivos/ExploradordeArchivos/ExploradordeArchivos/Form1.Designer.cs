namespace ExploradordeArchivos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.vistaIconosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.btnIconosPeque = new System.Windows.Forms.ToolStripMenuItem();
			this.btnIconosGrandes = new System.Windows.Forms.ToolStripMenuItem();
			this.btnIconosLista = new System.Windows.Forms.ToolStripMenuItem();
			this.btnIconosDetalles = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(697, 301);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(697, 326);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeView1);
			this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.listView1);
			this.splitContainer1.Size = new System.Drawing.Size(697, 301);
			this.splitContainer1.SplitterDistance = 232;
			this.splitContainer1.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.ImageIndex = 0;
			this.treeView1.ImageList = this.imageList1;
			this.treeView1.Location = new System.Drawing.Point(0, 24);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = 0;
			this.treeView1.Size = new System.Drawing.Size(232, 277);
			this.treeView1.TabIndex = 0;
			this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Folder");
			this.imageList1.Images.SetKeyName(1, "File");
			this.imageList1.Images.SetKeyName(2, "Folder32");
			this.imageList1.Images.SetKeyName(3, "PDF16");
			this.imageList1.Images.SetKeyName(4, "PDF32");
			this.imageList1.Images.SetKeyName(5, "DOC16");
			this.imageList1.Images.SetKeyName(6, "DOC32");
			this.imageList1.Images.SetKeyName(7, "File32");
			this.imageList1.Images.SetKeyName(8, "Excel16");
			this.imageList1.Images.SetKeyName(9, "Excel32");
			this.imageList1.Images.SetKeyName(10, "Java16");
			this.imageList1.Images.SetKeyName(11, "Java32");
			this.imageList1.Images.SetKeyName(12, "Php16");
			this.imageList1.Images.SetKeyName(13, "Php32");
			this.imageList1.Images.SetKeyName(14, "xml");
			this.imageList1.Images.SetKeyName(15, "xml32");
			this.imageList1.Images.SetKeyName(16, "css16.png");
			this.imageList1.Images.SetKeyName(17, "css32.png");
			this.imageList1.Images.SetKeyName(18, "html16");
			this.imageList1.Images.SetKeyName(19, "html32");
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vistaIconosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(232, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// vistaIconosToolStripMenuItem
			// 
			this.vistaIconosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.btnSalir});
			this.vistaIconosToolStripMenuItem.Name = "vistaIconosToolStripMenuItem";
			this.vistaIconosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.vistaIconosToolStripMenuItem.Text = "Archivo";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIconosPeque,
            this.btnIconosGrandes,
            this.btnIconosLista,
            this.btnIconosDetalles});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem1.Text = "Vista Iconos";
			// 
			// btnIconosPeque
			// 
			this.btnIconosPeque.Name = "btnIconosPeque";
			this.btnIconosPeque.Size = new System.Drawing.Size(180, 22);
			this.btnIconosPeque.Text = "Iconos Pequeños";
			this.btnIconosPeque.Click += new System.EventHandler(this.btnIconosPeque_Click);
			// 
			// btnIconosGrandes
			// 
			this.btnIconosGrandes.Name = "btnIconosGrandes";
			this.btnIconosGrandes.Size = new System.Drawing.Size(180, 22);
			this.btnIconosGrandes.Text = "Iconos Grandes";
			this.btnIconosGrandes.Click += new System.EventHandler(this.btnIconosGrandes_Click);
			// 
			// btnIconosLista
			// 
			this.btnIconosLista.Name = "btnIconosLista";
			this.btnIconosLista.Size = new System.Drawing.Size(180, 22);
			this.btnIconosLista.Text = "Lista";
			this.btnIconosLista.Click += new System.EventHandler(this.btnIconosLista_Click);
			// 
			// btnIconosDetalles
			// 
			this.btnIconosDetalles.Name = "btnIconosDetalles";
			this.btnIconosDetalles.Size = new System.Drawing.Size(180, 22);
			this.btnIconosDetalles.Text = "Detalle";
			this.btnIconosDetalles.Click += new System.EventHandler(this.btnIconosDetalles_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(180, 22);
			this.btnSalir.Text = "Salir";
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(461, 301);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.List;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Nombre";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tipo";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Última Modificación";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(697, 326);
			this.Controls.Add(this.toolStripContainer1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Explorador de Archivos";
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem vistaIconosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem btnIconosPeque;
		private System.Windows.Forms.ToolStripMenuItem btnIconosGrandes;
		private System.Windows.Forms.ToolStripMenuItem btnIconosLista;
		private System.Windows.Forms.ToolStripMenuItem btnIconosDetalles;
		private System.Windows.Forms.ToolStripMenuItem btnSalir;
	}
}

