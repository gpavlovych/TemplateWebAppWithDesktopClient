using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace $safeprojectname$
{
    public class TestAutoFixture : Fixture
    {
        public TestAutoFixture()
        {
            this.Customize(new AutoMoqCustomization());
        }
    }
}