namespace Service.Client
{
    public class ZuoraOptions
    {
        public string BaseUrl { get; set; }

        public string ClientID { get; set; }

        public string ClientSecret { get; set; }

        public string UserId { get; set; }

        public string ZuoraEntityId { get; set; }

        public string ZuoraIdempotencyKey { get; set; }

        public Guid? ZuoraTrackId { get; set; } = Guid.NewGuid();

    }
}