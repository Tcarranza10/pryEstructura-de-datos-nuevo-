namespace pryEstructura_de_datos__nuevo_
{
    partial class frmArbolBinario
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtInOrdenDes = new System.Windows.Forms.RadioButton();
            this.rbtPostOrden = new System.Windows.Forms.RadioButton();
            this.rbtPreOrden = new System.Windows.Forms.RadioButton();
            this.rbtInOrden = new System.Windows.Forms.RadioButton();
            this.dgvArbol = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbArbol = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtInOrdenDes);
            this.groupBox3.Controls.Add(this.rbtPostOrden);
            this.groupBox3.Controls.Add(this.rbtPreOrden);
            this.groupBox3.Controls.Add(this.rbtInOrden);
            this.groupBox3.Controls.Add(this.dgvArbol);
            this.groupBox3.Location = new System.Drawing.Point(8, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(666, 207);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado del árbol";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rbtInOrdenDes
            // 
            this.rbtInOrdenDes.AutoSize = true;
            this.rbtInOrdenDes.Location = new System.Drawing.Point(19, 71);
            this.rbtInOrdenDes.Name = "rbtInOrdenDes";
            this.rbtInOrdenDes.Size = new System.Drawing.Size(133, 17);
            this.rbtInOrdenDes.TabIndex = 29;
            this.rbtInOrdenDes.TabStop = true;
            this.rbtInOrdenDes.Text = "In-Orden Descendente";
            this.rbtInOrdenDes.UseVisualStyleBackColor = true;
            this.rbtInOrdenDes.CheckedChanged += new System.EventHandler(this.rbtInOrdenDes_CheckedChanged);
            // 
            // rbtPostOrden
            // 
            this.rbtPostOrden.AutoSize = true;
            this.rbtPostOrden.Location = new System.Drawing.Point(19, 143);
            this.rbtPostOrden.Name = "rbtPostOrden";
            this.rbtPostOrden.Size = new System.Drawing.Size(78, 17);
            this.rbtPostOrden.TabIndex = 28;
            this.rbtPostOrden.TabStop = true;
            this.rbtPostOrden.Text = "Post-Orden";
            this.rbtPostOrden.UseVisualStyleBackColor = true;
            this.rbtPostOrden.CheckedChanged += new System.EventHandler(this.rbtPostOrden_CheckedChanged);
            // 
            // rbtPreOrden
            // 
            this.rbtPreOrden.AutoSize = true;
            this.rbtPreOrden.Location = new System.Drawing.Point(19, 105);
            this.rbtPreOrden.Name = "rbtPreOrden";
            this.rbtPreOrden.Size = new System.Drawing.Size(73, 17);
            this.rbtPreOrden.TabIndex = 27;
            this.rbtPreOrden.TabStop = true;
            this.rbtPreOrden.Text = "Pre-Orden";
            this.rbtPreOrden.UseVisualStyleBackColor = true;
            this.rbtPreOrden.CheckedChanged += new System.EventHandler(this.rbtPreOrden_CheckedChanged);
            // 
            // rbtInOrden
            // 
            this.rbtInOrden.AutoSize = true;
            this.rbtInOrden.Location = new System.Drawing.Point(19, 36);
            this.rbtInOrden.Name = "rbtInOrden";
            this.rbtInOrden.Size = new System.Drawing.Size(126, 17);
            this.rbtInOrden.TabIndex = 26;
            this.rbtInOrden.TabStop = true;
            this.rbtInOrden.Text = "In-Orden Ascendente";
            this.rbtInOrden.UseVisualStyleBackColor = true;
            this.rbtInOrden.CheckedChanged += new System.EventHandler(this.rbtInOrden_CheckedChanged);
            // 
            // dgvArbol
            // 
            this.dgvArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvArbol.Location = new System.Drawing.Point(221, 19);
            this.dgvArbol.Name = "dgvArbol";
            this.dgvArbol.ReadOnly = true;
            this.dgvArbol.Size = new System.Drawing.Size(436, 170);
            this.dgvArbol.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 160;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.Name = "Tramite";
            this.Tramite.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbArbol);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(465, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 119);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Elemento";
            // 
            // cmbArbol
            // 
            this.cmbArbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArbol.FormattingEnabled = true;
            this.cmbArbol.Location = new System.Drawing.Point(86, 27);
            this.cmbArbol.Name = "cmbArbol";
            this.cmbArbol.Size = new System.Drawing.Size(89, 21);
            this.cmbArbol.TabIndex = 8;
            this.cmbArbol.SelectedIndexChanged += new System.EventHandler(this.cmbArbol_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(18, 61);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 31);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Código:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTramite);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(229, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 199);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(83, 115);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(89, 20);
            this.txtTramite.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(89, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(83, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(89, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 152);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 31);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trámite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(484, 164);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(156, 31);
            this.btnEquilibrar.TabIndex = 7;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(8, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(196, 199);
            this.treeView1.TabIndex = 25;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArbolBinario";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvArbol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbArbol;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.RadioButton rbtPostOrden;
        private System.Windows.Forms.RadioButton rbtPreOrden;
        private System.Windows.Forms.RadioButton rbtInOrden;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton rbtInOrdenDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
    }
}