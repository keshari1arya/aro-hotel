import { Injectable } from '@angular/core';
import { HotelService } from '../services/hotel.service';
import { createEffect, Actions, ofType } from '@ngrx/effects';
import * as AppActions from './app.actions';
import { exhaustMap, map } from 'rxjs';
import { Hotel } from '../infrastructure/models/hotel';

@Injectable()
export class AppEffects {
  constructor(private actions$: Actions, private hotelService: HotelService) {}

  getHotels$ = createEffect(() =>
    this.actions$.pipe(
      ofType(AppActions.getHotels),
      exhaustMap((action) =>
        this.hotelService
          .getHotels()
          .pipe(
            map((hotels: Hotel[]) => AppActions.setHotels({ hotels: hotels }))
          )
      )
    )
  );

  getHotelDetails$ = createEffect(() =>
    this.actions$.pipe(
      ofType(AppActions.getHotelDetails),
      exhaustMap((action) =>
        this.hotelService
          .getHotelDetails(action.id)
          .pipe(
            map((hotel: Hotel) => AppActions.setHotelDetails({ hotel: hotel }))
          )
      )
    )
  );
}
