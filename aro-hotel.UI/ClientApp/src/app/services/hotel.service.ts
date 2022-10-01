import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IHotel } from '../infrastructure/models/hotel';
import { ApiUrls } from '../infrastructure/url';

@Injectable({
  providedIn: 'root'
})
export class HotelService {

  constructor(private http: HttpClient) { }

  getHotels(): Observable<IHotel[]> {
    return this.http.get<IHotel[]>(ApiUrls.getHotels);
  }

  getHotelDetails(id: number): Observable<IHotel> {
    return this.http.get<IHotel>(`${ApiUrls.getHotels}/${id}`);
  }

  createHotel(hotel: IHotel): Observable<any> {
    return this.http.post(ApiUrls.createHotel, hotel);
  }
}
