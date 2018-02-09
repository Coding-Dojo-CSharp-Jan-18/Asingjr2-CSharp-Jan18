using System;
using System.ComponentModel.DataAnnotations;

// Creating a new namespace for the validators we have within model_form_prac aclled Validators
namespace model_form_prac.Validators
{
    /* 
    **********************
    Custom validation can be names anything but must inherit from the validationAttribute class
    Must contain the word attribute in name...need to overload/extend an existing method must be correct method/ function signature
    Creating custom validatiokn with two constructors that are used in Class Validation as [PastDate]....
    [PastDate] can be used with no arguements and have DateTime.Now as default...or we can pass one [PastDate(_date_)]
    */
    

    public class PastDateAttribute : ValidationAttribute
    {
        private DateTime _targetDate;  // Assigning base attribute of datetime for class
        public PastDateAttribute(string testDate)     // Method setting attribute to string that is
        {
            // assigning passed test/ submitted date to method...then assigned attribute as that submited date after converting it
            _targetDate = Convert.ToDateTime(testDate);
        }
        public PastDateAttribute()  // Default with no arguement, making attribute DateTime.Now, which then compares to IsValid built in
        {
            // assigning passed test/ submitted date to method...then assigned attribute as that submited date
            _targetDate = DateTime.Now;
        }
        /* ************************************************************* */
        // Below picked because it will return validation result
        // protected virtual ValidationResult IsValid(object value, ValidationContext validationContext);
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if((DateTime)value > _targetDate)
            {
            // Using string interpolation and converting _target date from datetime to string.
            return new ValidationResult($"Date must be before {_targetDate.ToString("D")}");
            }
            return ValidationResult.Success;
        }
    }
}
   

   /* ************************************************************
   Above custom validation is an overriden method for an existing method.
   In method we override the method and case easily into a datetime type */