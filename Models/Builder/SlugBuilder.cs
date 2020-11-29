namespace Sluger.Models.Builder
{
    public struct SlugBuilder
    {
        private USID _slug { get; set; }
        public USID Build() => _slug;

        public void BuildSlugLength()
        {
            
        }
    }
}