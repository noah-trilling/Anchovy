﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Anchovy.API.Client.Models
{
    public partial class Manager
    {
        private string _address;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }
        
        private string _city;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }
        
        private string _email;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        
        private string _firstName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }
        
        private int? _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _lastName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }
        
        private string _middleName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string MiddleName
        {
            get { return this._middleName; }
            set { this._middleName = value; }
        }
        
        private string _password;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }
        
        private string _phone;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }
        
        private double? _salary;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public double? Salary
        {
            get { return this._salary; }
            set { this._salary = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private string _username;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Manager class.
        /// </summary>
        public Manager()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken addressValue = inputObject["Address"];
                if (addressValue != null && addressValue.Type != JTokenType.Null)
                {
                    this.Address = ((string)addressValue);
                }
                JToken cityValue = inputObject["City"];
                if (cityValue != null && cityValue.Type != JTokenType.Null)
                {
                    this.City = ((string)cityValue);
                }
                JToken emailValue = inputObject["Email"];
                if (emailValue != null && emailValue.Type != JTokenType.Null)
                {
                    this.Email = ((string)emailValue);
                }
                JToken firstNameValue = inputObject["FirstName"];
                if (firstNameValue != null && firstNameValue.Type != JTokenType.Null)
                {
                    this.FirstName = ((string)firstNameValue);
                }
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((int)idValue);
                }
                JToken lastNameValue = inputObject["LastName"];
                if (lastNameValue != null && lastNameValue.Type != JTokenType.Null)
                {
                    this.LastName = ((string)lastNameValue);
                }
                JToken middleNameValue = inputObject["MiddleName"];
                if (middleNameValue != null && middleNameValue.Type != JTokenType.Null)
                {
                    this.MiddleName = ((string)middleNameValue);
                }
                JToken passwordValue = inputObject["Password"];
                if (passwordValue != null && passwordValue.Type != JTokenType.Null)
                {
                    this.Password = ((string)passwordValue);
                }
                JToken phoneValue = inputObject["Phone"];
                if (phoneValue != null && phoneValue.Type != JTokenType.Null)
                {
                    this.Phone = ((string)phoneValue);
                }
                JToken salaryValue = inputObject["Salary"];
                if (salaryValue != null && salaryValue.Type != JTokenType.Null)
                {
                    this.Salary = ((double)salaryValue);
                }
                JToken stateValue = inputObject["State"];
                if (stateValue != null && stateValue.Type != JTokenType.Null)
                {
                    this.State = ((string)stateValue);
                }
                JToken usernameValue = inputObject["Username"];
                if (usernameValue != null && usernameValue.Type != JTokenType.Null)
                {
                    this.Username = ((string)usernameValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type Manager
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Address != null)
            {
                outputObject["Address"] = this.Address;
            }
            if (this.City != null)
            {
                outputObject["City"] = this.City;
            }
            if (this.Email != null)
            {
                outputObject["Email"] = this.Email;
            }
            if (this.FirstName != null)
            {
                outputObject["FirstName"] = this.FirstName;
            }
            if (this.Id != null)
            {
                outputObject["Id"] = this.Id.Value;
            }
            if (this.LastName != null)
            {
                outputObject["LastName"] = this.LastName;
            }
            if (this.MiddleName != null)
            {
                outputObject["MiddleName"] = this.MiddleName;
            }
            if (this.Password != null)
            {
                outputObject["Password"] = this.Password;
            }
            if (this.Phone != null)
            {
                outputObject["Phone"] = this.Phone;
            }
            if (this.Salary != null)
            {
                outputObject["Salary"] = this.Salary.Value;
            }
            if (this.State != null)
            {
                outputObject["State"] = this.State;
            }
            if (this.Username != null)
            {
                outputObject["Username"] = this.Username;
            }
            return outputObject;
        }
    }
}
