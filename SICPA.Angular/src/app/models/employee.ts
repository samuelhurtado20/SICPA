export class Employee {
    id?: number;
    age: number;
    email: string;
    name: string;
    position: string;
    surname: string;

    constructor(id: number, age: number, email: string, name: string, position: string, surname: string)
    {
        this.id = id;
        this.age = age;
        this.email = email;
        this.name = name;
        this.position = position;
        this.surname = surname;
    }
}