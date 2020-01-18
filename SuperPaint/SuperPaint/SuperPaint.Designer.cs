namespace SuperPaint
{
    partial class FrmColors
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDrawing = new System.Windows.Forms.PictureBox();
            this.picPickColor = new System.Windows.Forms.PictureBox();
            this.picLightColor = new System.Windows.Forms.PictureBox();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblHexaColor = new System.Windows.Forms.Label();
            this.picShowColor = new System.Windows.Forms.PictureBox();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDrawing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPickColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLightColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowColor)).BeginInit();
            this.SuspendLayout();
            // 
            // picDrawing
            // 
            this.picDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picDrawing.BackColor = System.Drawing.Color.Transparent;
            this.picDrawing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDrawing.Location = new System.Drawing.Point(10, 10);
            this.picDrawing.Name = "picDrawing";
            this.picDrawing.Size = new System.Drawing.Size(500, 500);
            this.picDrawing.TabIndex = 0;
            this.picDrawing.TabStop = false;
            this.picDrawing.Click += new System.EventHandler(this.picDrawing_Click);
            this.picDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.picDrawing_Paint);
            this.picDrawing.MouseLeave += new System.EventHandler(this.picDrawing_MouseLeave);
            this.picDrawing.MouseHover += new System.EventHandler(this.picDrawing_MouseHover);
            this.picDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDrawing_MouseMove);
            // 
            // picPickColor
            // 
            this.picPickColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPickColor.BackColor = System.Drawing.Color.White;
            this.picPickColor.Location = new System.Drawing.Point(558, 10);
            this.picPickColor.Name = "picPickColor";
            this.picPickColor.Size = new System.Drawing.Size(200, 200);
            this.picPickColor.TabIndex = 1;
            this.picPickColor.TabStop = false;
            this.picPickColor.Paint += new System.Windows.Forms.PaintEventHandler(this.picPickColor_Paint);
            // 
            // picLightColor
            // 
            this.picLightColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLightColor.BackColor = System.Drawing.Color.White;
            this.picLightColor.Location = new System.Drawing.Point(837, 10);
            this.picLightColor.Name = "picLightColor";
            this.picLightColor.Size = new System.Drawing.Size(60, 200);
            this.picLightColor.TabIndex = 2;
            this.picLightColor.TabStop = false;
            this.picLightColor.Paint += new System.Windows.Forms.PaintEventHandler(this.picLightColor_Paint);
            // 
            // lblRed
            // 
            this.lblRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.White;
            this.lblRed.Location = new System.Drawing.Point(607, 349);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(51, 20);
            this.lblRed.TabIndex = 3;
            this.lblRed.Text = "label1";
            // 
            // lblGreen
            // 
            this.lblGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.ForeColor = System.Drawing.Color.White;
            this.lblGreen.Location = new System.Drawing.Point(607, 379);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(51, 20);
            this.lblGreen.TabIndex = 4;
            this.lblGreen.Text = "label1";
            // 
            // lblBlue
            // 
            this.lblBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.ForeColor = System.Drawing.Color.White;
            this.lblBlue.Location = new System.Drawing.Point(607, 409);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(51, 20);
            this.lblBlue.TabIndex = 5;
            this.lblBlue.Text = "label2";
            // 
            // lblHexaColor
            // 
            this.lblHexaColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHexaColor.AutoSize = true;
            this.lblHexaColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHexaColor.ForeColor = System.Drawing.Color.White;
            this.lblHexaColor.Location = new System.Drawing.Point(687, 319);
            this.lblHexaColor.Name = "lblHexaColor";
            this.lblHexaColor.Size = new System.Drawing.Size(51, 20);
            this.lblHexaColor.TabIndex = 6;
            this.lblHexaColor.Text = "label2";
            // 
            // picShowColor
            // 
            this.picShowColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picShowColor.BackColor = System.Drawing.Color.White;
            this.picShowColor.Location = new System.Drawing.Point(664, 346);
            this.picShowColor.Name = "picShowColor";
            this.picShowColor.Size = new System.Drawing.Size(100, 100);
            this.picShowColor.TabIndex = 7;
            this.picShowColor.TabStop = false;
            this.picShowColor.Paint += new System.Windows.Forms.PaintEventHandler(this.picShowColor_Paint);
            // 
            // tmrTick
            // 
            this.tmrTick.Enabled = true;
            this.tmrTick.Interval = 16;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // FrmColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.picShowColor);
            this.Controls.Add(this.lblHexaColor);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.picLightColor);
            this.Controls.Add(this.picPickColor);
            this.Controls.Add(this.picDrawing);
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FrmColors";
            this.Text = "SuperPaint";
            this.Load += new System.EventHandler(this.FrmColors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDrawing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPickColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLightColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDrawing;
        private System.Windows.Forms.PictureBox picPickColor;
        private System.Windows.Forms.PictureBox picLightColor;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblHexaColor;
        private System.Windows.Forms.PictureBox picShowColor;
        private System.Windows.Forms.Timer tmrTick;
    }
}

