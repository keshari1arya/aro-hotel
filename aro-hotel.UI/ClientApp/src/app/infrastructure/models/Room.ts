import { IMultimedia } from "./Multimedia";


export interface IRoom {
  roomType: string;
  occupancy: number;
  multimedias: IMultimedia[];
  facilities: string[];
  price?: number;
}
