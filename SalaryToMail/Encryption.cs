using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SalaryToMail
{
  class Encryption
  {
    //默認密鈅加密算法
    private readonly byte[] rgbKEY = { 0x01, 0x23, 0x11, 0x23, 0xfe, 0x51, 0x73, 0xb5 };
    private readonly byte[] rgbIV = { 0x11, 0x03, 0x51, 0x64, 0x8e, 0x5b, 0x39, 0x54 };


    public string Encode(string data)
    {
      try
      {
        byte[] inputByteArray = Encoding.UTF8.GetBytes(data);
        DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
        MemoryStream mStream = new MemoryStream();
        CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKEY, rgbIV), CryptoStreamMode.Write);
        cStream.Write(inputByteArray, 0, inputByteArray.Length);
        cStream.FlushFinalBlock();
        return Convert.ToBase64String(mStream.ToArray());
      }
      catch
      {
        return data;
      }
    }

    public string Decode(string data)
    {
      try
      {
        byte[] inputByteArray = Convert.FromBase64String(data);
        DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
        MemoryStream mStream = new MemoryStream();
        CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKEY, rgbIV), CryptoStreamMode.Write);
        cStream.Write(inputByteArray, 0, inputByteArray.Length);
        cStream.FlushFinalBlock();
        return Encoding.UTF8.GetString(mStream.ToArray());
      }
      catch
      {
        return data;
      }
    }
  }
}
