import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'age'
})
export class AgePipe implements PipeTransform {

  transform(value: string): number {
    
    const today = new Date();
    const dob = new Date(value);

    let age = today.getFullYear() - dob.getFullYear();
    const monthDiff = today.getMonth() - dob.getMonth();
    const DayDiff = today.getDate() - dob.getDate();

    if(monthDiff < 0 || (monthDiff === 0 && DayDiff < 0))
        age--;


    return age;
  }

}
