using Sluger.Models.Builder;

namespace Sluger.Models.Factory
{
    public struct SlugFactory
    {
        private SlugBuilder _builder { get; set; }

        public USID GetResult() => new SlugBuilder().Build();
    }
}