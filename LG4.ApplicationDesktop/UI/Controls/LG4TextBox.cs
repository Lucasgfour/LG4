using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.ApplicationDesktop.UI.Controls {
    public class LG4TextBox : MaterialTextBox2 {

		private String[] Numeros = new String[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
		private String[] Letras = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };


		public string MaskCustom { get; set; }
        public LG4Mask MaskType { get; set; }

        public LG4TextBox() {

            this.UseTallSize = false;
            this.MaskCustom = "AA.11";
            this.MaskType = LG4Mask.None;
            this.TextChanged += TextMaskChanged;

        }

        private void TextMaskChanged(object? sender, EventArgs e) {

            if (this.MaskType != LG4Mask.None)
				FormatMask();

		}

		private String[] StringToArray(String str) => str.ToCharArray().Select(x => x.ToString()).ToArray();

		private bool hasPrefixMask(int position) => !(masks[position].Equals("A") || masks[position].Equals("1"));

		string[] letters = new string[0];
		string[] masks = new string[0];

		private bool maskValidation(string letter, int position) {

			var mask = masks[position];

			if (mask.Equals("A") && this.Letras.Contains(letter.ToUpper()))
				return true;

			if (mask.Equals("1") && this.Numeros.Contains(letter.ToUpper()))
				return true;

			if (hasPrefixMask(position) && letter.Equals(mask))
				return true;

			return false;

		}

		private void MaskHelper() {

			var number = 0.0;

			

			if (this.MaskType == LG4Mask.Decimal && double.TryParse(this.Text.Replace(",", "."), out number)) {


				var cleanText = number.ToString().Replace(",", "");

				if (cleanText.Length < 3) {
					this.MaskCustom = "".PadLeft(this.Text.Length, '1');
				} else {
					var countLeft = this.Text.Length;

					if (!this.Text.Contains(","))
						countLeft += 1;

					this.MaskCustom = ",11".PadLeft(countLeft, '1');
				}
					
			}
			
			if(this.MaskType == LG4Mask.Integer) this.MaskCustom = "".PadLeft(this.Text.Length, '1');

		}

		private void FormatMask() {

			MaskHelper();

			letters = StringToArray(this.Text);
			masks = StringToArray(this.MaskCustom);

			var cursorPosition = this.SelectionStart;
			var value = "";

			for (int i = 0; i < letters.Length; i++) {

				if (masks.Length > value.Length) {

					var letter = letters[i];

					var isOK = maskValidation(letter, value.Length);
					var isPrefix = hasPrefixMask(value.Length);

					if (isPrefix) {

						value = value + masks[value.Length];

						if(masks.Length > value.Length + 1)
							isOK = maskValidation(letter, value.Length + 1);


					}

					if (isOK)
						value = value + letter;

				}

			}

			if (!value.Equals(this.Text)) {

				var oldValue = this.Text;

				this.Text = value;

				if (value.Length > oldValue.Length)
					cursorPosition += (value.Length - oldValue.Length);

				if(value.Length < oldValue.Length)
					cursorPosition -= (value.Length - oldValue.Length);

				if (value.Length < cursorPosition)
					cursorPosition += value.Length;

				this.SelectionStart = cursorPosition;

			}
		}
	}

    public enum LG4Mask {
        
        None,
        Decimal,
        Integer,
        Custom
       

    }
}
