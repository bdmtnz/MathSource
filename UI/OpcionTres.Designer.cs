﻿namespace UI
{
    partial class OpcionTres
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
            this.funcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pasosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFuncionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idResultadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funcionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // funcionesBindingSource
            // 
            this.funcionesBindingSource.DataSource = typeof(ENTITY.Funciones);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idFuncionDataGridViewTextBoxColumn,
            this.idResultadoDataGridViewTextBoxColumn,
            this.entradaDataGridViewTextBoxColumn,
            this.salidaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pasosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // pasosBindingSource
            // 
            this.pasosBindingSource.DataSource = typeof(ENTITY.Pasos);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // idFuncionDataGridViewTextBoxColumn
            // 
            this.idFuncionDataGridViewTextBoxColumn.DataPropertyName = "Id_Funcion";
            this.idFuncionDataGridViewTextBoxColumn.HeaderText = "Id_Funcion";
            this.idFuncionDataGridViewTextBoxColumn.Name = "idFuncionDataGridViewTextBoxColumn";
            // 
            // idResultadoDataGridViewTextBoxColumn
            // 
            this.idResultadoDataGridViewTextBoxColumn.DataPropertyName = "Id_Resultado";
            this.idResultadoDataGridViewTextBoxColumn.HeaderText = "Id_Resultado";
            this.idResultadoDataGridViewTextBoxColumn.Name = "idResultadoDataGridViewTextBoxColumn";
            // 
            // entradaDataGridViewTextBoxColumn
            // 
            this.entradaDataGridViewTextBoxColumn.DataPropertyName = "Entrada";
            this.entradaDataGridViewTextBoxColumn.HeaderText = "Entrada";
            this.entradaDataGridViewTextBoxColumn.Name = "entradaDataGridViewTextBoxColumn";
            // 
            // salidaDataGridViewTextBoxColumn
            // 
            this.salidaDataGridViewTextBoxColumn.DataPropertyName = "Salida";
            this.salidaDataGridViewTextBoxColumn.HeaderText = "Salida";
            this.salidaDataGridViewTextBoxColumn.Name = "salidaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pasos";
            // 
            // OpcionTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpcionTres";
            this.Text = "OpcionTres";
            ((System.ComponentModel.ISupportInitialize)(this.funcionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource funcionesBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idResultadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pasosBindingSource;
        private System.Windows.Forms.Label label1;
    }
}