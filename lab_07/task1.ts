interface Employee {
  id: number;
  name: string;
  salary: number;
  displayInfo(): void;
}

class EmployeeClass implements Employee {
  id: number;
  name: string;
  salary: number;

  constructor(id: number, name: string, salary: number) {
    this.id = id;
    this.name = name;
    this.salary = salary;
  }

  displayInfo(): void {
    console.log(`ID: ${this.id}, Name: ${this.name}, Salary: ${this.salary}`);
  }
}

let emp = new EmployeeClass(1, "Ali", 50000);
emp.displayInfo();
