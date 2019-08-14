namespace SGDB
{
    partial class Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.trBD = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCrear = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gvTablas = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearTabla = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarTabla = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarTabla = new System.Windows.Forms.ToolStripMenuItem();
            this.indiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearIndice = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarIndice = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarIndice = new System.Windows.Forms.ToolStripMenuItem();
            this.btMostrarP = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearProcedimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarProcedimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarProcedimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearFunciones = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarFuncion = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarFuncion = new System.Windows.Forms.ToolStripMenuItem();
            this.btMostrarT = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearTrigger = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarTrigger = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrarTrigger = new System.Windows.Forms.ToolStripMenuItem();
            this.btMostrarC = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarChecks = new System.Windows.Forms.ToolStripMenuItem();
            this.btMostrarV = new System.Windows.Forms.ToolStripMenuItem();
            this.btCrearView = new System.Windows.Forms.ToolStripMenuItem();
            this.btBorrarView = new System.Windows.Forms.ToolStripMenuItem();
            this.btMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btMostrarF = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.btUsers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTablas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trBD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 508);
            this.panel1.TabIndex = 0;
            // 
            // trBD
            // 
            this.trBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trBD.Location = new System.Drawing.Point(0, 0);
            this.trBD.Name = "trBD";
            this.trBD.Size = new System.Drawing.Size(213, 508);
            this.trBD.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(777, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(690, 135);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(213, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 135);
            this.panel2.TabIndex = 3;
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(213, 337);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(100, 58);
            this.btCrear.TabIndex = 4;
            this.btCrear.Text = "Crear BD";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.BtCrear_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(319, 337);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(100, 58);
            this.btActualizar.TabIndex = 5;
            this.btActualizar.Text = "Modificar BD";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.BtActualizar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(425, 337);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(100, 58);
            this.btBorrar.TabIndex = 6;
            this.btBorrar.Text = "Borrar BD";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.BtBorrar_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(531, 337);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(100, 58);
            this.btRefresh.TabIndex = 7;
            this.btRefresh.Text = "Refrescar";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gvTablas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(213, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 152);
            this.panel3.TabIndex = 8;
            // 
            // gvTablas
            // 
            this.gvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTablas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTablas.Location = new System.Drawing.Point(0, 0);
            this.gvTablas.Name = "gvTablas";
            this.gvTablas.RowHeadersWidth = 51;
            this.gvTablas.RowTemplate.Height = 24;
            this.gvTablas.Size = new System.Drawing.Size(690, 152);
            this.gvTablas.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasToolStripMenuItem,
            this.indiceToolStripMenuItem,
            this.btMostrarP,
            this.funcionesToolStripMenuItem,
            this.btMostrarT,
            this.btMostrarC,
            this.btMostrarV});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearTabla,
            this.ModificarTabla,
            this.EliminarTabla,
            this.btMostrar});
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.tablasToolStripMenuItem.Text = "Tablas";
            // 
            // CrearTabla
            // 
            this.CrearTabla.Name = "CrearTabla";
            this.CrearTabla.Size = new System.Drawing.Size(224, 26);
            this.CrearTabla.Text = "Crear";
            this.CrearTabla.Click += new System.EventHandler(this.CrearTabla_Click);
            // 
            // ModificarTabla
            // 
            this.ModificarTabla.Name = "ModificarTabla";
            this.ModificarTabla.Size = new System.Drawing.Size(224, 26);
            this.ModificarTabla.Text = "Modificar";
            this.ModificarTabla.Click += new System.EventHandler(this.ModificarTabla_Click);
            // 
            // EliminarTabla
            // 
            this.EliminarTabla.Name = "EliminarTabla";
            this.EliminarTabla.Size = new System.Drawing.Size(224, 26);
            this.EliminarTabla.Text = "Eliminar";
            this.EliminarTabla.Click += new System.EventHandler(this.EliminarTabla_Click);
            // 
            // indiceToolStripMenuItem
            // 
            this.indiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearIndice,
            this.ModificarIndice,
            this.EliminarIndice,
            this.Mostrar});
            this.indiceToolStripMenuItem.Name = "indiceToolStripMenuItem";
            this.indiceToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.indiceToolStripMenuItem.Text = "Indice";
            // 
            // CrearIndice
            // 
            this.CrearIndice.Name = "CrearIndice";
            this.CrearIndice.Size = new System.Drawing.Size(224, 26);
            this.CrearIndice.Text = "Crear";
            this.CrearIndice.Click += new System.EventHandler(this.CrearIndice_Click);
            // 
            // ModificarIndice
            // 
            this.ModificarIndice.Name = "ModificarIndice";
            this.ModificarIndice.Size = new System.Drawing.Size(224, 26);
            this.ModificarIndice.Text = "Modificar";
            // 
            // EliminarIndice
            // 
            this.EliminarIndice.Name = "EliminarIndice";
            this.EliminarIndice.Size = new System.Drawing.Size(224, 26);
            this.EliminarIndice.Text = "Eliminar";
            this.EliminarIndice.Click += new System.EventHandler(this.EliminarIndice_Click);
            // 
            // btMostrarP
            // 
            this.btMostrarP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearProcedimientos,
            this.ModificarProcedimiento,
            this.EliminarProcedimiento,
            this.mostrarToolStripMenuItem});
            this.btMostrarP.Name = "btMostrarP";
            this.btMostrarP.Size = new System.Drawing.Size(126, 24);
            this.btMostrarP.Text = "Procedimientos";
            // 
            // CrearProcedimientos
            // 
            this.CrearProcedimientos.Name = "CrearProcedimientos";
            this.CrearProcedimientos.Size = new System.Drawing.Size(224, 26);
            this.CrearProcedimientos.Text = "Crear";
            this.CrearProcedimientos.Click += new System.EventHandler(this.CrearProcedimientos_Click);
            // 
            // ModificarProcedimiento
            // 
            this.ModificarProcedimiento.Name = "ModificarProcedimiento";
            this.ModificarProcedimiento.Size = new System.Drawing.Size(224, 26);
            this.ModificarProcedimiento.Text = "Modificar";
            // 
            // EliminarProcedimiento
            // 
            this.EliminarProcedimiento.Name = "EliminarProcedimiento";
            this.EliminarProcedimiento.Size = new System.Drawing.Size(224, 26);
            this.EliminarProcedimiento.Text = "Eliminar";
            this.EliminarProcedimiento.Click += new System.EventHandler(this.EliminarProcedimiento_Click);
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearFunciones,
            this.ModificarFuncion,
            this.EliminarFuncion,
            this.btMostrarF});
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.funcionesToolStripMenuItem.Text = "Funciones";
            // 
            // CrearFunciones
            // 
            this.CrearFunciones.Name = "CrearFunciones";
            this.CrearFunciones.Size = new System.Drawing.Size(224, 26);
            this.CrearFunciones.Text = "Crear";
            this.CrearFunciones.Click += new System.EventHandler(this.CrearFunciones_Click);
            // 
            // ModificarFuncion
            // 
            this.ModificarFuncion.Name = "ModificarFuncion";
            this.ModificarFuncion.Size = new System.Drawing.Size(224, 26);
            this.ModificarFuncion.Text = "Modificar";
            // 
            // EliminarFuncion
            // 
            this.EliminarFuncion.Name = "EliminarFuncion";
            this.EliminarFuncion.Size = new System.Drawing.Size(224, 26);
            this.EliminarFuncion.Text = "Eliminar";
            this.EliminarFuncion.Click += new System.EventHandler(this.EliminarFuncion_Click);
            // 
            // btMostrarT
            // 
            this.btMostrarT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearTrigger,
            this.ModificarTrigger,
            this.BorrarTrigger,
            this.mostrarToolStripMenuItem2});
            this.btMostrarT.Name = "btMostrarT";
            this.btMostrarT.Size = new System.Drawing.Size(76, 24);
            this.btMostrarT.Text = "Triggers";
            // 
            // CrearTrigger
            // 
            this.CrearTrigger.Name = "CrearTrigger";
            this.CrearTrigger.Size = new System.Drawing.Size(224, 26);
            this.CrearTrigger.Text = "Crear";
            this.CrearTrigger.Click += new System.EventHandler(this.CrearTrigger_Click);
            // 
            // ModificarTrigger
            // 
            this.ModificarTrigger.Name = "ModificarTrigger";
            this.ModificarTrigger.Size = new System.Drawing.Size(224, 26);
            this.ModificarTrigger.Text = "Modificar";
            // 
            // BorrarTrigger
            // 
            this.BorrarTrigger.Name = "BorrarTrigger";
            this.BorrarTrigger.Size = new System.Drawing.Size(224, 26);
            this.BorrarTrigger.Text = "Borrar";
            this.BorrarTrigger.Click += new System.EventHandler(this.BorrarTrigger_Click);
            // 
            // btMostrarC
            // 
            this.btMostrarC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearCheck,
            this.ModificarCheck,
            this.EliminarChecks,
            this.mostrarToolStripMenuItem3});
            this.btMostrarC.Name = "btMostrarC";
            this.btMostrarC.Size = new System.Drawing.Size(68, 24);
            this.btMostrarC.Text = "Checks";
            // 
            // CrearCheck
            // 
            this.CrearCheck.Name = "CrearCheck";
            this.CrearCheck.Size = new System.Drawing.Size(224, 26);
            this.CrearCheck.Text = "Crear";
            this.CrearCheck.Click += new System.EventHandler(this.CrearCheck_Click);
            // 
            // ModificarCheck
            // 
            this.ModificarCheck.Name = "ModificarCheck";
            this.ModificarCheck.Size = new System.Drawing.Size(224, 26);
            this.ModificarCheck.Text = "Modificar";
            // 
            // EliminarChecks
            // 
            this.EliminarChecks.Name = "EliminarChecks";
            this.EliminarChecks.Size = new System.Drawing.Size(224, 26);
            this.EliminarChecks.Text = "Eliminar";
            this.EliminarChecks.Click += new System.EventHandler(this.EliminarChecks_Click);
            // 
            // btMostrarV
            // 
            this.btMostrarV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btCrearView,
            this.btBorrarView,
            this.mostrarToolStripMenuItem4});
            this.btMostrarV.Name = "btMostrarV";
            this.btMostrarV.Size = new System.Drawing.Size(61, 24);
            this.btMostrarV.Text = "Views";
            // 
            // btCrearView
            // 
            this.btCrearView.Name = "btCrearView";
            this.btCrearView.Size = new System.Drawing.Size(224, 26);
            this.btCrearView.Text = "Crear";
            this.btCrearView.Click += new System.EventHandler(this.BtCrearView_Click);
            // 
            // btBorrarView
            // 
            this.btBorrarView.Name = "btBorrarView";
            this.btBorrarView.Size = new System.Drawing.Size(224, 26);
            this.btBorrarView.Text = "Borrar";
            this.btBorrarView.Click += new System.EventHandler(this.BtBorrarView_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(224, 26);
            this.btMostrar.Text = "Mostrar Tablas";
            this.btMostrar.Click += new System.EventHandler(this.BtMostrar_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(224, 26);
            this.Mostrar.Text = "Mostrar Indices";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // btMostrarF
            // 
            this.btMostrarF.Name = "btMostrarF";
            this.btMostrarF.Size = new System.Drawing.Size(224, 26);
            this.btMostrarF.Text = "Mostrar";
            // 
            // mostrarToolStripMenuItem2
            // 
            this.mostrarToolStripMenuItem2.Name = "mostrarToolStripMenuItem2";
            this.mostrarToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.mostrarToolStripMenuItem2.Text = "Mostrar";
            // 
            // mostrarToolStripMenuItem3
            // 
            this.mostrarToolStripMenuItem3.Name = "mostrarToolStripMenuItem3";
            this.mostrarToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.mostrarToolStripMenuItem3.Text = "Mostrar";
            // 
            // mostrarToolStripMenuItem4
            // 
            this.mostrarToolStripMenuItem4.Name = "mostrarToolStripMenuItem4";
            this.mostrarToolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.mostrarToolStripMenuItem4.Text = "Mostrar";
            // 
            // btUsers
            // 
            this.btUsers.Location = new System.Drawing.Point(679, 337);
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(114, 58);
            this.btUsers.TabIndex = 10;
            this.btUsers.Text = "Usuarios";
            this.btUsers.UseVisualStyleBackColor = true;
            this.btUsers.Click += new System.EventHandler(this.BtUsers_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 536);
            this.Controls.Add(this.btUsers);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTablas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView trBD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gvTablas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btMostrarP;
        private System.Windows.Forms.ToolStripMenuItem funcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btMostrarT;
        private System.Windows.Forms.ToolStripMenuItem CrearTrigger;
        private System.Windows.Forms.ToolStripMenuItem ModificarTrigger;
        private System.Windows.Forms.ToolStripMenuItem BorrarTrigger;
        private System.Windows.Forms.ToolStripMenuItem btMostrarC;
        private System.Windows.Forms.ToolStripMenuItem CrearTabla;
        private System.Windows.Forms.ToolStripMenuItem ModificarTabla;
        private System.Windows.Forms.ToolStripMenuItem EliminarTabla;
        private System.Windows.Forms.ToolStripMenuItem CrearIndice;
        private System.Windows.Forms.ToolStripMenuItem ModificarIndice;
        private System.Windows.Forms.ToolStripMenuItem EliminarIndice;
        private System.Windows.Forms.ToolStripMenuItem CrearProcedimientos;
        private System.Windows.Forms.ToolStripMenuItem ModificarProcedimiento;
        private System.Windows.Forms.ToolStripMenuItem EliminarProcedimiento;
        private System.Windows.Forms.ToolStripMenuItem CrearFunciones;
        private System.Windows.Forms.ToolStripMenuItem ModificarFuncion;
        private System.Windows.Forms.ToolStripMenuItem EliminarFuncion;
        private System.Windows.Forms.ToolStripMenuItem CrearCheck;
        private System.Windows.Forms.ToolStripMenuItem ModificarCheck;
        private System.Windows.Forms.ToolStripMenuItem EliminarChecks;
        private System.Windows.Forms.ToolStripMenuItem btMostrarV;
        private System.Windows.Forms.ToolStripMenuItem btCrearView;
        private System.Windows.Forms.ToolStripMenuItem btBorrarView;
        private System.Windows.Forms.ToolStripMenuItem btMostrar;
        private System.Windows.Forms.ToolStripMenuItem Mostrar;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btMostrarF;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem4;
        private System.Windows.Forms.Button btUsers;
    }
}