//variables - string, int, boolean
const firstName = "Neehar";
let age = 23;
const hasLicense = true;
//firstName = "x";          //error will be shown TypeError: Assignment to constant variable.
age = 24;                   //changed age value
console.log(age);           //prints new age
console.log(`I am ${firstName} and I am ${age} years old and has license: ${hasLicense}.`);


//functions
function add(a,b){          //function declaration(add)
    return a+b;
}
console.log(add(2,3));

const multiply = function(a,b){         //function expression(multiply)
    return a*b;
};
console.log(multiply(5,6));

const greet = (person) => {return(`Hello ${person}!`)};     //arrow function(greet)
console.log(greet("Gaurav"));


//arrays - map & filter
const numbers = [1,2,3,4,5,6];
console.log(numbers);

const doubled = numbers.map((n) => n*2);        //map - transforms every items in array
console.log(doubled);

const even = numbers.filter((n) => (n%2===0));      //filter - filters arrays based on the conditions
console.log(even);

//combining both map & filter
const doubledEvens = numbers.filter((n) => n%2 === 0).map((n) => n *2);
console.log(doubledEvens);

console.log(numbers);       //original array


//objects

//create object - person
const person = {
    fullName: "Neehar",
    age: 23,
    hobby: ["music","workout"],
    greet: function () {
        return `Hello! I am ${this.fullName} and I am ${this.age} years old`;
    },
};
console.log(person);

//read values from object
console.log("Second hobby:", person.hobby[1]);

//change or add to object
person.age = 24;
person.city = "Kerala";

console.log("Person:", person);
console.log(person.greet());

