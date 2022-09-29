import { createAction, props } from '@ngrx/store';
import { Hotel } from '../infrastructure/models/hotel';

export const getHotels = createAction('[App] get hotels');
export const setHotels = createAction(
  '[App] set hotels',
  props<{ hotels: Hotel[] }>()
);

export const getHotelDetails = createAction(
  '[App] get hotel details',
  props<{ id: number }>()
);
export const setHotelDetails = createAction(
  '[App] set hotel details',
  props<{ hotel: Hotel }>()
);
