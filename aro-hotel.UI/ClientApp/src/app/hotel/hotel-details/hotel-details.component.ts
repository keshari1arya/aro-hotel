import { Component, OnInit } from '@angular/core';

import { Observable } from 'rxjs';
import { Hotel } from 'src/app/infrastructure/models/hotel';
import { Multimedia } from 'src/app/infrastructure/models/Multimedia';
import { HotelService } from 'src/app/services/hotel.service';

@Component({
  selector: 'app-hotel-details',
  templateUrl: './hotel-details.component.html',
  styleUrls: ['./hotel-details.component.css']
})
export class HotelDetailsComponent implements OnInit {
  hotel?: Hotel;

  constructor(private hotelService: HotelService) { }

  ngOnInit(): void {
    this.hotelService.getHotelDetails(1).subscribe(x => {
      console.log(x)
      this.hotel = x;
    });
  }

  getImage(image: Multimedia): string {
    if (image) {
      return image.url;
    }
    return '';
  }
}
