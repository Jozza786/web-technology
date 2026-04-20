const fs = require('fs');

fs.writeFileSync('student.txt', 'Name: Jozza Batool \nCourse: ADnCS\nRoll No: 101\nUniversity: AIR UNIVERSITY ');

const data = fs.readFileSync('student.txt', 'utf8');

console.log(data);