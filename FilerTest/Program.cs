using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string thePath = @"H:\2015\semester 2\PR 283 C#\Theseus\FilerTesting\level10.txt";
            string newPath = @"H:\Documents";
            Loader theLoader = new Loader();
            Saver theSaver = new Saver();
            Compressor theCompressor = new Compressor();
            Decompressor theDecompressor = new Decompressor();
            FileHandler theFiler = new FileHandler();

            /*Console.WriteLine("Loading map from txt file");

            theLoader.SetFilePath(thePath);
            theLoader.ExtractFileContents();
            theLoader.ToStringArray();*/

            /*theSaver.SetMap(theLoader.GetMap());
            theSaver.SetFileName("Test Map");
            theSaver.SaveFile(newPath);*/
            theLoader.LoadMultipleMaps();
            theLoader.ParseMap();



            /*theCompressor.LoadMap(theLoader.GetMap(theLoader.GetOriginalMaps(), "Map 2."));
            
            Console.WriteLine("\nFinding character positions & removing from string:\n");
            theCompressor.FindSpecialCharacters();
            Console.WriteLine("\nStage 1 compression: \n");
            theCompressor.CompressLevel1();
            Console.WriteLine("\nStage 2 compression: \n");
            theCompressor.ShrinkLevel2();
            Console.WriteLine("\nString to be exported:\n");
            theCompressor.SetTheResult();


            
            theDecompressor.SetCompressed(theCompressor.GetResult());
            theDecompressor.SeparateToArrays();

            Console.WriteLine("\nStage 2 decompression: \n");

            theDecompressor.DecompressLevel2();
            Console.WriteLine("\nStage 1 decompression: \n");
            theDecompressor.DecompressLevel1();
            Console.WriteLine("\nAdding characters back in: \n");
            theDecompressor.SetCharacters();

            /*Console.WriteLine("Loading all maps from file");
            theLoader.LoadMultipleMaps();
            theLoader.ParseMap();
            theLoader.Test();
            theLoader.GetMap(theLoader.GetOriginalMaps(), "Map 1.");
            theLoader.GetMap(theLoader.GetOriginalMaps(), "Map 7.");*/


            theFiler.SaveMultiple(theLoader.GetOriginalMaps(), newPath, "Compressed original maps");



            Console.ReadKey();
        }
    }
}
