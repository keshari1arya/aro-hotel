import { IAddress } from "./IAddress";
import { Multimedia } from "./Multimedia";
import { Room } from "./Room";

export interface Hotel {
    id: number;
    name: string;
    description: string;
    address: IAddress;
    phone: string;
    multimedias: Multimedia[],
    rooms: Room[],
    facilities: string[],
}

