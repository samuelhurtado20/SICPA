export class Enterprise {
    id?: number;
    name: string;
    address: string;
    phone: string;

    constructor(id: number, name: string, address: string, phone: string)
    {
        this.id = id;
        this.name = name;
        this.address = address;
        this.phone = phone;
    }
}