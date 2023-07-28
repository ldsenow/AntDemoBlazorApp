namespace AntDemoBlazorApp.Client.Components
{
    public class CustomSelectOption<TValue>
    {
        public TValue Value { get; set; }
        public string Label { get; set; }

        //public override bool Equals(object? obj)
        //{
        //    if (obj is CustomSelectOption<TValue> option)
        //    {
        //        return option.Value.Equals(Value);
        //    }

        //    return false;
        //}

        //public override int GetHashCode() => Value == null ? Value.GetHashCode();
    }
}
