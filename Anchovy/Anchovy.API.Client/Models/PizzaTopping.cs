﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Anchovy.API.Client.Models;
using Newtonsoft.Json.Linq;

namespace Anchovy.API.Client.Models
{
    public partial class PizzaTopping
    {
        private int? _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private Pizza _pizza;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public Pizza Pizza
        {
            get { return this._pizza; }
            set { this._pizza = value; }
        }
        
        private int? _pizzaId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? PizzaId
        {
            get { return this._pizzaId; }
            set { this._pizzaId = value; }
        }
        
        private Topping _topping;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public Topping Topping
        {
            get { return this._topping; }
            set { this._topping = value; }
        }
        
        private int? _toppingId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? ToppingId
        {
            get { return this._toppingId; }
            set { this._toppingId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the PizzaTopping class.
        /// </summary>
        public PizzaTopping()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((int)idValue);
                }
                JToken pizzaValue = inputObject["Pizza"];
                if (pizzaValue != null && pizzaValue.Type != JTokenType.Null)
                {
                    Pizza pizza = new Pizza();
                    pizza.DeserializeJson(pizzaValue);
                    this.Pizza = pizza;
                }
                JToken pizzaIdValue = inputObject["PizzaId"];
                if (pizzaIdValue != null && pizzaIdValue.Type != JTokenType.Null)
                {
                    this.PizzaId = ((int)pizzaIdValue);
                }
                JToken toppingValue = inputObject["Topping"];
                if (toppingValue != null && toppingValue.Type != JTokenType.Null)
                {
                    Topping topping = new Topping();
                    topping.DeserializeJson(toppingValue);
                    this.Topping = topping;
                }
                JToken toppingIdValue = inputObject["ToppingId"];
                if (toppingIdValue != null && toppingIdValue.Type != JTokenType.Null)
                {
                    this.ToppingId = ((int)toppingIdValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type PizzaTopping
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Id != null)
            {
                outputObject["Id"] = this.Id.Value;
            }
            if (this.Pizza != null)
            {
                outputObject["Pizza"] = this.Pizza.SerializeJson(null);
            }
            if (this.PizzaId != null)
            {
                outputObject["PizzaId"] = this.PizzaId.Value;
            }
            if (this.Topping != null)
            {
                outputObject["Topping"] = this.Topping.SerializeJson(null);
            }
            if (this.ToppingId != null)
            {
                outputObject["ToppingId"] = this.ToppingId.Value;
            }
            return outputObject;
        }
    }
}