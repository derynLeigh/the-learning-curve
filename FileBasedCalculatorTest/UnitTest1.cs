using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CalculatorTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestFileCreation()
        {
            string f1Path = Calculator.f1Path;
            string f2Path = Calculator.f2Path;
            string outputPath = Calculator.outputPath;

            File.WriteAllText(f1Path, "10\n20\n30\n");
            File.WriteAllText(f2Path, "5\n15\n25\n");

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                StringReader sr = new StringReader("+\n");
                Console.SetIn(sr);

                Calculator.Main(new string[0]);

                Assert.IsTrue(File.Exists(outputPath));
            }

            File.Delete(f1Path);
            File.Delete(f2Path);
            File.Delete(outputPath);
        }

        [TestMethod]
        public void TestFileDataAddition()
        {
            string f1Path = Calculator.f1Path;
            string f2Path = Calculator.f2Path;
            string outputPath = Calculator.outputPath;

            File.WriteAllText(f1Path, "10\n20\n30\n");
            File.WriteAllText(f2Path, "5\n15\n25\n");

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                StringReader sr = new StringReader("+\n");
                Console.SetIn(sr);

                Calculator.Main(new string[0]);

                Assert.IsTrue(File.Exists(outputPath));

                string[] outputLines = File.ReadAllLines(outputPath);

                // Expected results
                float[] expectedResults = { 15, 35, 55 };

                for (int i = 0; i < expectedResults.Length; i++)
                {
                    Assert.AreEqual(expectedResults[i], float.Parse(outputLines[i]));
                }
            }

            // Deleting test files
            File.Delete(f1Path);
            File.Delete(f2Path);
            File.Delete(outputPath);
        }

        [TestMethod]
        public void TestFileDataSubtraction()
        {
            string f1Path = Calculator.f1Path;
            string f2Path = Calculator.f2Path;
            string outputPath = Calculator.outputPath;

            File.WriteAllText(f1Path, "20\n30\n40\n");
            File.WriteAllText(f2Path, "5\n15\n25\n");

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                StringReader sr = new StringReader("-\n");
                Console.SetIn(sr);

                Calculator.Main(new string[0]);

                Assert.IsTrue(File.Exists(outputPath));

                string[] outputLines = File.ReadAllLines(outputPath);

                // Expected results
                float[] expectedResults = { 15, 15, 15 };

                for (int i = 0; i < expectedResults.Length; i++)
                {
                    Assert.AreEqual(expectedResults[i], float.Parse(outputLines[i]));
                }
            }

            // Deleting test files
            File.Delete(f1Path);
            File.Delete(f2Path);
            File.Delete(outputPath);
        }

        [TestMethod]
        public void TestFileDataDivision()
        {
            string f1Path = Calculator.f1Path;
            string f2Path = Calculator.f2Path;
            string outputPath = Calculator.outputPath;

            File.WriteAllText(f1Path, "20\n30\n40\n");
            File.WriteAllText(f2Path, "5\n3\n2\n");

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                StringReader sr = new StringReader("/\n");
                Console.SetIn(sr);

                Calculator.Main(new string[0]);

                Assert.IsTrue(File.Exists(outputPath));

                string[] outputLines = File.ReadAllLines(outputPath);

                // Expected results
                float[] expectedResults = { 4, 10, 20 };

                for (int i = 0; i < expectedResults.Length; i++)
                {
                    Assert.AreEqual(expectedResults[i], float.Parse(outputLines[i]));
                }
            }

            // Deleting test files
            File.Delete(f1Path);
            File.Delete(f2Path);
            File.Delete(outputPath);
        }

        [TestMethod]
        public void TestFileDataMultiplication()
        {
            string f1Path = Calculator.f1Path;
            string f2Path = Calculator.f2Path;
            string outputPath = Calculator.outputPath;

            File.WriteAllText(f1Path, "2\n5\n10\n");
            File.WriteAllText(f2Path, "3\n4\n5\n");

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                StringReader sr = new StringReader("*\n");
                Console.SetIn(sr);

                Calculator.Main(new string[0]);

                Assert.IsTrue(File.Exists(outputPath));

                string[] outputLines = File.ReadAllLines(outputPath);

                // Expected results
                float[] expectedResults = { 6, 20, 50 };

                for (int i = 0; i < expectedResults.Length; i++)
                {
                    Assert.AreEqual(expectedResults[i], float.Parse(outputLines[i]));
                }
            }

            // Deleting test files
            File.Delete(f1Path);
            File.Delete(f2Path);
            File.Delete(outputPath);
        }
    }
}