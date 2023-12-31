using System.Linq;

namespace CMN.Extentions
{
    public static class Mapper
    {
        public static TOutput Map<TOutput, TInput>(this TInput inputDto)
            where TOutput : class, new() 
            where TInput : class 
        {

            var properties = typeof(TInput).GetProperties()
                .Where(prop => prop.Name != "Id") 
                .ToList();

            var outputDto = new TOutput();

            foreach (var property in properties)
            {
                var value = property.GetValue(inputDto);
                var outputProperty = typeof(TOutput).GetProperty(property.Name);
                if (outputProperty != null)
                {
                    outputProperty.SetValue(outputDto, value);
                }
            }
            return outputDto;
        }
        public static TOutput Map<TOutput, TInput>(this TInput inputDto,TOutput entity)
            where TOutput : class, new()
            where TInput : class
        {

            var properties = typeof(TInput).GetProperties()
                .Where(prop => prop.Name != "Id")
                .ToList();

            

            foreach (var property in properties)
            {
                var value = property.GetValue(inputDto);
                var outputProperty = typeof(TOutput).GetProperty(property.Name);
                if (outputProperty != null)
                {
                    outputProperty.SetValue(entity, value);
                }
            }
            return entity;
        }
    }

}
