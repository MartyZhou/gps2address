namespace Cluj.GPS2Address
{
    public struct GoogleAddressType
    {
        public string long_name { get; set; }
        public string short_name { get; set; }
        public string[] types { get; set; }
    }

    public struct GoogleAddressInfo
    {
        public GoogleAddressType[] address_components { get; set; }
        public string formatted_address { get; set; }
        public string place_id { get; set; }
        public GoogleGeometry geometry { get; set; }
        public string[] types { get; set; }
    }

    public struct GoogleLocation
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public struct GoogleBounds
    {
        public GoogleLocation northeast { get; set; }
        public GoogleLocation southwest { get; set; }
    }

    public struct GoogleGeometry
    {
        public GoogleBounds bounds { get; set; }
        public string[] types { get; set; }
    }

    public struct GoogleAddressResult
    {
        public GoogleAddressInfo[] results { get; set; }
    }

    public struct GoogleAddress{
        public GoogleAddressInfo Address { get; set; }
        public GoogleAddressInfo Parent { get; set; }
    }
}