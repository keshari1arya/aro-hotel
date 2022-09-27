import { Component, OnInit } from '@angular/core';
import { Hotel } from 'src/app/infrastructure/models/hotel';
import { HotelService } from 'src/app/services/hotel.service';

@Component({
  selector: 'app-hotel-list',
  templateUrl: './hotel-list.component.html',
  styleUrls: ['./hotel-list.component.css']
})
export class HotelListComponent implements OnInit {
  hotels: Hotel[]=[];
  constructor(private hotelService: HotelService) { }

  ngOnInit(): void {
    this.hotelService.getHotels()
      .subscribe(x => {
        this.hotels = x;
      })
  }

}
