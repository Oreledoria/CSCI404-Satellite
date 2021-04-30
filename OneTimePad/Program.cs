﻿using System;
using System.IO;
using System.Text;

namespace OneTimePad
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageFile = new StreamReader("D:/404 Test Files/TestingMethods/TestingMethods/message.txt").ReadToEnd();
            Console.WriteLine("Beginning Message:");
            Console.WriteLine(messageFile + "\n");
            // Converting text to bytes, assuming unicode.
            byte[] originalBytes = Encoding.Unicode.GetBytes(messageFile);

            // generate a pad in memory.
            byte[] pad = GeneratePad(size: originalBytes.Length, seed: 1);

            // I'm going to display these bytes in Base64, but one would
            // probably save them to a file; this is the Pad (or "key").
            Console.WriteLine("The one time pad.");
            Console.WriteLine(Convert.ToBase64String(inArray: pad) + "\n");

            // We encrypt the bytes by adding our noise.
            byte[] encrypted = Encrypt(originalBytes, pad);
            // again, displaying in base64, but you would typically save
            // these to a file too; this is your encrypted "file" or message.
            var encryptito = Convert.ToBase64String(inArray: encrypted);
            Console.WriteLine("Encrypted Message:");
            Console.WriteLine(encryptito + "\n");
            byte[] encryptedFromBase64 = Convert.FromBase64String(encryptito);

            // decrypting the encoded message using the key made up of noise.
            byte[] decrypted = Decrypt(encryptedFromBase64, pad);

            // displaying the original unencrypted message.
            Console.WriteLine("The decrypted message.");
            Console.WriteLine(Encoding.Unicode.GetString(decrypted) + "\n");
        }

        public static byte[] GeneratePad(int size, int seed)
        {
            var random = new Random(Seed: seed);
            var bytesBuffel = new byte[size];

            random.NextBytes(bytesBuffel);

            return bytesBuffel;
        }

        public static byte[] Encrypt(byte[] data, byte[] pad)
        {
            var result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                var sum = (int)data[i] + (int)pad[i];
                if (sum > 255)
                    sum -= 255;
                result[i] = (byte)sum;
            }
            return result;
        }

        public static byte[] Decrypt(byte[] encrypted, byte[] pad)
        {
            var result = new byte[encrypted.Length];
            for (int i = 0; i < encrypted.Length; i++)
            {
                var dif = (int)encrypted[i] - (int)pad[i];
                if (dif < 0)
                    dif += 255;
                result[i] = (byte)dif;
            }
            return result;
        }

    }
}
