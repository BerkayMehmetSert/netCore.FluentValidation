namespace netCore.FluentValidation.Constants
{
    public static class ProductMessage
    {
        public const string NameIsRequired = "Name is required";
        public const string NameLength = "Name must be between 3 and 50 characters";
        public const string DescriptionIsRequired = "Description is required";
        public const string DescriptionLength = "Description must be between 3 and 20 characters";
        public const string PriceIsRequired = "Price is required";
        public const string PriceGreaterThan = "Price must be greater than 0";
        public const string ProductNotFoundById = " Product not found by Id.";
    }
}
