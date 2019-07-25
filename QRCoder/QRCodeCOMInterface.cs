using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace QRCoder
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class QRCodeCOMInterface
    {
        private static QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
        private QRCodeData qRCodeData;

        public string PlainText
        {
            set
            {
                qRCodeData = qRCodeGenerator.CreateQrCode(value, QRCodeGenerator.ECCLevel.M, false, false, QRCodeGenerator.EciMode.Default, 3);
            }
        }
        public System.Drawing.Bitmap QRCodeBMP
        {
            get
            {
                QRCode qRCode = new QRCode(qRCodeData);
                return qRCode.GetGraphic(20);
            }
        }
        public byte[] QRCodeByte
        {
            get
            {
                BitmapByteQRCode bitmapByteQRCode = new BitmapByteQRCode(qRCodeData);
                return bitmapByteQRCode.GetGraphic(20);
            }
        }

    }
}
