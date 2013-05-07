using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PipelineRunner.Stages;

namespace PipelineRunner.Tests
{
    [TestFixture]
    public class StageSetup_Tests
    {
        class ParseFromString : AsyncJob<String, int>
        {
            public override int Perform(string param)
            {
                throw new NotImplementedException();
            }
        }

        class DivideByPI : AsyncJob<int, Double>
        {
            public override double Perform(int param)
            {
                throw new NotImplementedException();
            }
        }

        class Format : AsyncJob<Double, String>
        {
            public override string Perform(double param)
            {
                throw new NotImplementedException();
            }
        }


        [Test]
        public void StageSetup_Assert()
        {
            var setup = Config
                .Stage(new ParseFromString())
                .Stage(new DivideByPI())
                .Stage(new Format());

            Assert.That(setup.Current, Is.Not.Null);
            Assert.That(setup.Current.Next, Is.Null, "The Current.Next should must be null, is the last one");
            Assert.That(setup.Current.Job, Is.Not.Null, "The Current.Job should not be null");
            Assert.That(setup.Current.First, Is.Not.Null, "The Current.First should not be null");

        }

    }
}
