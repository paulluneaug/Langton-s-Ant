using System;
using System.Drawing;
using System.Windows.Forms;

namespace Langton_s_Ant
{
    partial class Form1
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
        private void InitializeComponent(int nX, int nY, int boxSize)
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(boxSize * nX, boxSize * nY);
            this.Text = "Langton's Ant : Step 0";

            this.CanvasBox = new System.Windows.Forms.PictureBox();
            this.StepsLab = new System.Windows.Forms.Label();
            // 
            // CanvasBox
            // 
            this.CanvasBox.Location = new System.Drawing.Point(0, 0);
            this.CanvasBox.Name = "CanvasBox";
            this.CanvasBox.Size = new System.Drawing.Size(boxSize * nX, boxSize * nY);
            this.CanvasBox.TabIndex = 0;
            this.CanvasBox.TabStop = false;
            this.CanvasBox.BackColor = Color.Black;
            this.CanvasBox.Paint += new PaintEventHandler(CanvasBox_Paint);
            this.Controls.Add(this.CanvasBox);

            // 
            // StepsLab
            // 
            this.StepsLab.AutoSize = true;
            this.StepsLab.ForeColor = Color.Red;
            this.StepsLab.Font = new Font("Consolas", 12);
            this.StepsLab.Location = new System.Drawing.Point(100, 100);
            this.StepsLab.Name = "StepsLab";
            this.StepsLab.Size = new System.Drawing.Size(100, 100);
            this.StepsLab.TabIndex = 11;
            this.StepsLab.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.Controls.Add(this.StepsLab);
        }

        #endregion


        private PictureBox CanvasBox;
        private Label StepsLab;
    }
}

