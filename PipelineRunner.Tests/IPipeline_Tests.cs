using NUnit.Framework;
using PipelineRunner.Stages;
using System;
using System.Collections.Generic;

namespace PipelineRunner.Tests
{
    [TestFixture]
    public class IPipeline_Tests
    {

        class ParseFromString : AsyncJob<String, int>
        {
            public override int Perform(string param)
            {
                return int.Parse(param);
            }
            public override string ToString()
            {
                return "ParseFromString";
            }
        }

        class DivideByPI : AsyncJob<int, double>
        {
            public override double Perform(int param)
            {
                return param / Math.PI;
            }
            public override string ToString()
            {
                return "DivideByPI";
            }
        }

        class Format : AsyncJob<double, String>
        {
            public override string Perform(double param)
            {
                return param.ToString();
            }
            public override string ToString()
            {
                return "Format";
            }
        }

        private static StageSetup<double, string> ConfigStages()
        {
            var setup = Config
                .Stage(new ParseFromString())
                .Stage(new DivideByPI())
                .Stage(new Format());

            return setup;
        }

        [Test]
        public void IPipeline_Assert_Creation()
        {
            var pipeline = Pipeline.Create<String>(ConfigStages());

            var param = new List<String>();

            for (int i = 0; i < 1000; i++)
            {
                param.Add("" + i);
            }

            pipeline.Run(param);
        }

    }
}
