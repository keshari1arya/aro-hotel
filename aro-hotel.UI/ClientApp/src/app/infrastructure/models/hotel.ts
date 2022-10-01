import { IAddress } from "./IAddress";
import { IMultimedia } from "./Multimedia";
import { IRoom } from "./Room";

export interface IHotel {
  id?: number;
  name?: string;
  description?: string;
  address?: IAddress;
  phone?: string;
  multimedias?: IMultimedia[],
  rooms?: IRoom[],
  facilities?: string[],
  discount?: number;
}

