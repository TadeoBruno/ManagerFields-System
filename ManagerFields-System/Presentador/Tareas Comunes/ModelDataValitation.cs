using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ManagerFields_System.Presentador.Tareas_Comunes
{
    public class ModelDataValitation
    {
        public void Validate(object model)
        {
            string errorMessages = "";
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, results, true);
            if (isValid==false)
            {
                foreach (var item in results)
                    errorMessages += "- " + item.ErrorMessage + "\n";
                throw new Exception(errorMessages);
            }
        }
    }
}
