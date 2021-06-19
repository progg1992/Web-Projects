import { Injectable } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
<<<<<<< HEAD
import { from, Observable, throwError } from 'rxjs';
import { switchMap, map, catchError} from 'rxjs/operators'
import { AuthService } from 'src/auth/service/auth.service';
=======
import { from, Observable } from 'rxjs';
>>>>>>> cb660b093820e831ec0c8d15c6816f25b3cca0b1
import { Repository } from 'typeorm';
import { UserEntity } from '../model/user.entity';
import { User } from '../model/user.interface';

@Injectable()
export class UserService {

    constructor(
<<<<<<< HEAD
        @InjectRepository(UserEntity) private readonly userRepository: Repository<UserEntity>,
        private authService: AuthService
    ) { }
    
    create(user: User): Observable<User> {
        return this.authService.hashPassword(user.password).pipe(
            switchMap((passwordHash: string) => {
                const newUser = new UserEntity();
                newUser.name = user.name;
                newUser.username = user.username;
                newUser.email = user.email;
                newUser.password = passwordHash;

                return from(this.userRepository.save(newUser)).pipe(
                    map((user: User) => {
                        const {password, ...result} = user;
                        return result;
                    }),
                    catchError(err => throwError(err))
                )
            })
        )
    }

    findOne(id: number): Observable<User> {
        return from(this.userRepository.findOneOrFail(id)).pipe(
            map((user: User) => {
                const { password, ...result } = user;
                return result;
            })
        )
    }

    findAll(): Observable<User[]> {
        return from(this.userRepository.find()).pipe(
            map((users) => {
                users.forEach(function (v) { delete v.password });
                return users;
            })
        )
=======
        @InjectRepository(UserEntity) private readonly userRepository: Repository<UserEntity>
    ) { }
    
    create(user: User): Observable<User> {
        return from(this.userRepository.save(user));
    }

    findOne(id: number): Observable<User> {
        return from(this.userRepository.findOneOrFail(id))
    }

    findAll(): Observable<User[]> {
        return from(this.userRepository.find());
>>>>>>> cb660b093820e831ec0c8d15c6816f25b3cca0b1
    }

    deletOne(id: number): Observable<any> {
        return from(this.userRepository.delete(id));
    }

    updateOne(id: number, user: User): Observable<any> {
<<<<<<< HEAD
        delete user.email;
        delete user.password;

        return from(this.userRepository.update(id, user));
    }

    login(user: User): Observable<string> {
        return this.validateUser(user.email, user.password).pipe(
            switchMap((user: User) => {
                if (user) {
                    return this.authService.generateJWT(user).pipe(map((jwt: string) => jwt));
                } else {
                    return 'Wrong Credentials';
                }
            })
        )
    }

    validateUser(email: string, password: string): Observable<User> {
        return this.findByEmail(email).pipe(
            switchMap((user: User) => this.authService.comparePasswords(password, user.password).pipe(
                map((match: boolean) => {
                    if (match) {
                        const { password, ...result } = user;
                        return result;
                    } else {
                        throwError
                    }
                })
            ))
        )
    }

    findByEmail(email: string): Observable<User> {
        return from(this.userRepository.findOneOrFail({email}))
    }
=======
        return from(this.userRepository.update(id, user));
    }
>>>>>>> cb660b093820e831ec0c8d15c6816f25b3cca0b1
}
