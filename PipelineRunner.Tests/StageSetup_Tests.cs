using NUnit.Framework;
using PipelineRunner.Jobs;
using PipelineRunner.Stages;
using System;

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

        private static StageSetup<double, string> ConfigStages()
        {
            var setup = Config
                .Stage(new ParseFromString())
                .Stage(new DivideByPI())
                .Stage(new Format());

            return setup;
        }

        [Test]
        public void StageSetup_Assert_Current()
        {
            var setup = ConfigStages();

            Assert.That(setup.Current, Is.Not.Null);
            Assert.That(setup.Current.Next, Is.Null, "The Current.Next should must be null, is the last one");
            Assert.That(setup.Current.Job, Is.Not.Null, "The Current.Job should not be null");
            Assert.That(setup.Current.First, Is.Not.Null, "The Current.First should not be null");

        }

        [Test]
        public void StageSetup_Assert_First()
        {
            var setup = ConfigStages();

            var first = setup.Current.First;

            Assert.That(first, Is.Not.Null);
            Assert.That(first.Next, Is.Not.Null, "The First.Next should not be null");
            Assert.That(first.Job, Is.Not.Null, "The First.Job should not be null");
            Assert.That(first.First, Is.Not.Null, "The First.First should not be null");
        }

        [Test]
        public void StageSetup_Assert_Stage_Count()
        {
            var setup = ConfigStages();

            var first = setup.Current.First;

            var current = first;
            var i = 0;
            while (current != null)
            {
                ++i;
                current = current.Next;
            }

            Assert.That(i, Is.EqualTo(3));            
        }
    }
}
