using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace $safeprojectname$
{
    public class TestAutoFixture : Fixture
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public TestAutoFixture()
        {
            this.Customize(new AutoMoqCustomization());
        }
    }
}