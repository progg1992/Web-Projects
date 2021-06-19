import { Body, Controller, Get, Param, Post, Put, Delete } from '@nestjs/common';
<<<<<<< HEAD
import { Observable, of } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
=======
import { Observable } from 'rxjs';
>>>>>>> cb660b093820e831ec0c8d15c6816f25b3cca0b1
import { User } from '../model/user.interface';
import { UserService } from '../service/user.service';

@Controller('user')
export class UserController {

    constructor(private userService: UserService) { }
    
    @Post()
<<<<<<< HEAD
    create(@Body()user: User): Observable<User | Object> {
        return this.userService.create(user).pipe(
            map((user: User) => user),
            catchError(err => of({ error: err.message }))
        );
    }

    @Post('login')
    login(@Body() user: User): Observable<Object> {
        return this.userService.login(user).pipe(
            map((jwt: string) => {
                return { access_token: jwt };
            })
        )
        }

=======
    create(@Body()user: User): Observable<User> {
        return this.userService.create(user);
    }

>>>>>>> cb660b093820e831ec0c8d15c6816f25b3cca0b1
    @Get(':id')
    findOne(@Param() params): Observable<User> {
        return this.userService.findOne(params.id);
    }

    @Get()
    findAll(): Observable<User[]> {
        return this.userService.findAll();
    }

    @Delete(':id')
    deleteOne(@Param('id')id: string): Observable<User> {
        return this.userService.deletOne(Number(id));
    }

    @Put(':id')
    updateOne(@Param('id') id: string, @Body() user: User): Observable<any> {
        return this.userService.updateOne(Number(id), user);
    }
}
