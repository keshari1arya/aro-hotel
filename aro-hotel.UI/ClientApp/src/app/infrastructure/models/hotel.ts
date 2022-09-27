export interface Hotel {
    id: number;
    name: string;
    description: string;
    address: IAddress;
    phone: string;
}

export interface IAddress {
    line1: string;
    line2: string,
    city: string,
    state: string,
    country: string,
    pincode: string,
    landMark: string,
}