import { Multimedia } from "./Multimedia";


export interface Room {
  roomType: string;
  occupancy: number;
  multimedias: Multimedia[];
  facilities: string[];
  price?: number;
}
