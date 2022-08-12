export class Department {
    id?: number;
    enterpriseId: number;
    name: string;
    description: string;
    phone: string;

    constructor(id: number, enterpriseId: number, name: string, description: string, phone: string)
    {
        this.id = id;
        this.enterpriseId = enterpriseId;
        this.name = name;
        this.description = description;
        this.phone = phone;
    }
}