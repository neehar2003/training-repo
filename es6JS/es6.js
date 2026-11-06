//module import
import introduce, { appName, multiply } from "./utils.js";


//let & const
//const - cant be reassigned
const personName = "Neehar";
console.log(personName);

//let - can be reassigned
let age = 23;
console.log(age);
age = 24;
console.log(age);

//arrow function
const add=(a, b) =>{
    return a+b;
};
const square = n => n*n;  //only 1 parameter here

console.log(add(7,7));
console.log(square(7));

const greet = userName => "Hello " + userName;
console.log(greet(personName));


//template literal(backticks)
console.log(`Hello ${personName}, u are ${age} years old.`);
console.log(`7 square = ${square(7)}`);  //calling function


//destructuring 
//takes out values from array or objects , assign it with individual variables
const person = {
    fullName: "Neehar",
    old:24,
    city:"Kerala"
};

//object descrturing
const { fullName, city } = person;
console.log(fullName, city);

const { country = "Portugal"} = person;
console.log(country);

//array destructuring
const colors = ["white", "red", "green"];
const [first, second]=colors;
console.log(first,second);

const [, , third] = colors;       //skips item 
console.log(third);


//spread
//spreads items of array or properties of objects into new place
const fruits = ["apple", "banana"];
const vegetables = ["carrot", "potato"];
const food =[...fruits, ...vegetables];     //combines to food
console.log(food);

const addFruits = [...fruits, "watermelon"];   //copies fruits to new array, and adds fruit - watermelon
console.log(addFruits);
console.log(fruits);

const nums = [1,7,3];
console.log(Math.max(...nums));   //gets maximum number from nums array



//using imported values
console.log(appName);

console.log(multiply(5, 10));

console.log(introduce(fullName, city));
