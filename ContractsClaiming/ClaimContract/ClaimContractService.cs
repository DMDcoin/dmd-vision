using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using DMDVision.ContractsClaiming.ClaimContract.ContractDefinition;

namespace DMDVision.ContractsClaiming.ClaimContract
{
    public partial class ClaimContractService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, ClaimContractDeployment claimContractDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<ClaimContractDeployment>().SendRequestAndWaitForReceiptAsync(claimContractDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, ClaimContractDeployment claimContractDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<ClaimContractDeployment>().SendRequestAsync(claimContractDeployment);
        }

        public static async Task<ClaimContractService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, ClaimContractDeployment claimContractDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, claimContractDeployment, cancellationTokenSource);
            return new ClaimContractService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public ClaimContractService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> BalancesQueryAsync(BalancesFunction balancesFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BalancesFunction, BigInteger>(balancesFunction, blockParameter);
        }

        
        public Task<BigInteger> BalancesQueryAsync(byte[] returnValue1, BlockParameter blockParameter = null)
        {
            var balancesFunction = new BalancesFunction();
                balancesFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<BalancesFunction, BigInteger>(balancesFunction, blockParameter);
        }

        public Task<string> GetPublicKeyFromBitcoinSignatureQueryAsync(GetPublicKeyFromBitcoinSignatureFunction getPublicKeyFromBitcoinSignatureFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPublicKeyFromBitcoinSignatureFunction, string>(getPublicKeyFromBitcoinSignatureFunction, blockParameter);
        }

        
        public Task<string> GetPublicKeyFromBitcoinSignatureQueryAsync(byte[] hashValue, byte[] r, byte[] s, byte v, BlockParameter blockParameter = null)
        {
            var getPublicKeyFromBitcoinSignatureFunction = new GetPublicKeyFromBitcoinSignatureFunction();
                getPublicKeyFromBitcoinSignatureFunction.HashValue = hashValue;
                getPublicKeyFromBitcoinSignatureFunction.R = r;
                getPublicKeyFromBitcoinSignatureFunction.S = s;
                getPublicKeyFromBitcoinSignatureFunction.V = v;
            
            return ContractHandler.QueryAsync<GetPublicKeyFromBitcoinSignatureFunction, string>(getPublicKeyFromBitcoinSignatureFunction, blockParameter);
        }

        public Task<byte[]> PublicKeyToBitcoinAddressQueryAsync(PublicKeyToBitcoinAddressFunction publicKeyToBitcoinAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PublicKeyToBitcoinAddressFunction, byte[]>(publicKeyToBitcoinAddressFunction, blockParameter);
        }

        
        public Task<byte[]> PublicKeyToBitcoinAddressQueryAsync(byte[] a_publicKeyX, byte[] a_publicKeyY, byte a_nAddressType, BlockParameter blockParameter = null)
        {
            var publicKeyToBitcoinAddressFunction = new PublicKeyToBitcoinAddressFunction();
                publicKeyToBitcoinAddressFunction.A_publicKeyX = a_publicKeyX;
                publicKeyToBitcoinAddressFunction.A_publicKeyY = a_publicKeyY;
                publicKeyToBitcoinAddressFunction.A_nAddressType = a_nAddressType;
            
            return ContractHandler.QueryAsync<PublicKeyToBitcoinAddressFunction, byte[]>(publicKeyToBitcoinAddressFunction, blockParameter);
        }

        public Task<string> PublicKeyToEthereumAddressQueryAsync(PublicKeyToEthereumAddressFunction publicKeyToEthereumAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PublicKeyToEthereumAddressFunction, string>(publicKeyToEthereumAddressFunction, blockParameter);
        }

        
        public Task<string> PublicKeyToEthereumAddressQueryAsync(byte[] a_publicKeyX, byte[] a_publicKeyY, BlockParameter blockParameter = null)
        {
            var publicKeyToEthereumAddressFunction = new PublicKeyToEthereumAddressFunction();
                publicKeyToEthereumAddressFunction.A_publicKeyX = a_publicKeyX;
                publicKeyToEthereumAddressFunction.A_publicKeyY = a_publicKeyY;
            
            return ContractHandler.QueryAsync<PublicKeyToEthereumAddressFunction, string>(publicKeyToEthereumAddressFunction, blockParameter);
        }

        public Task<bool> ValidateSignatureQueryAsync(ValidateSignatureFunction validateSignatureFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidateSignatureFunction, bool>(validateSignatureFunction, blockParameter);
        }

        
        public Task<bool> ValidateSignatureQueryAsync(byte[] hash, byte v, byte[] r, byte[] s, string address, BlockParameter blockParameter = null)
        {
            var validateSignatureFunction = new ValidateSignatureFunction();
                validateSignatureFunction.Hash = hash;
                validateSignatureFunction.V = v;
                validateSignatureFunction.R = r;
                validateSignatureFunction.S = s;
                validateSignatureFunction.Address = address;
            
            return ContractHandler.QueryAsync<ValidateSignatureFunction, bool>(validateSignatureFunction, blockParameter);
        }

        public Task<bool> ECDSAVerifyQueryAsync(ECDSAVerifyFunction eCDSAVerifyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ECDSAVerifyFunction, bool>(eCDSAVerifyFunction, blockParameter);
        }

        
        public Task<bool> ECDSAVerifyQueryAsync(string addressClaiming, byte[] publicKeyX, byte[] publicKeyY, byte v, byte[] r, byte[] s, BlockParameter blockParameter = null)
        {
            var eCDSAVerifyFunction = new ECDSAVerifyFunction();
                eCDSAVerifyFunction.AddressClaiming = addressClaiming;
                eCDSAVerifyFunction.PublicKeyX = publicKeyX;
                eCDSAVerifyFunction.PublicKeyY = publicKeyY;
                eCDSAVerifyFunction.V = v;
                eCDSAVerifyFunction.R = r;
                eCDSAVerifyFunction.S = s;
            
            return ContractHandler.QueryAsync<ECDSAVerifyFunction, bool>(eCDSAVerifyFunction, blockParameter);
        }

        public Task<string> CheckSignatureQueryAsync(CheckSignatureFunction checkSignatureFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CheckSignatureFunction, string>(checkSignatureFunction, blockParameter);
        }

        
        public Task<string> CheckSignatureQueryAsync(byte[] hash, byte[] r, byte[] s, byte v, BlockParameter blockParameter = null)
        {
            var checkSignatureFunction = new CheckSignatureFunction();
                checkSignatureFunction.Hash = hash;
                checkSignatureFunction.R = r;
                checkSignatureFunction.S = s;
                checkSignatureFunction.V = v;
            
            return ContractHandler.QueryAsync<CheckSignatureFunction, string>(checkSignatureFunction, blockParameter);
        }

        public Task<string> PubKeyToEthAddressQueryAsync(PubKeyToEthAddressFunction pubKeyToEthAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PubKeyToEthAddressFunction, string>(pubKeyToEthAddressFunction, blockParameter);
        }

        
        public Task<string> PubKeyToEthAddressQueryAsync(byte[] pubKeyX, byte[] pubKeyY, BlockParameter blockParameter = null)
        {
            var pubKeyToEthAddressFunction = new PubKeyToEthAddressFunction();
                pubKeyToEthAddressFunction.PubKeyX = pubKeyX;
                pubKeyToEthAddressFunction.PubKeyY = pubKeyY;
            
            return ContractHandler.QueryAsync<PubKeyToEthAddressFunction, string>(pubKeyToEthAddressFunction, blockParameter);
        }

        public Task<byte[]> CalcHash256QueryAsync(CalcHash256Function calcHash256Function, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CalcHash256Function, byte[]>(calcHash256Function, blockParameter);
        }

        
        public Task<byte[]> CalcHash256QueryAsync(byte[] data, BlockParameter blockParameter = null)
        {
            var calcHash256Function = new CalcHash256Function();
                calcHash256Function.Data = data;
            
            return ContractHandler.QueryAsync<CalcHash256Function, byte[]>(calcHash256Function, blockParameter);
        }

        public Task<byte[]> CalculateAddressStringQueryAsync(CalculateAddressStringFunction calculateAddressStringFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CalculateAddressStringFunction, byte[]>(calculateAddressStringFunction, blockParameter);
        }

        
        public Task<byte[]> CalculateAddressStringQueryAsync(string addr, bool includeAddrChecksum, BlockParameter blockParameter = null)
        {
            var calculateAddressStringFunction = new CalculateAddressStringFunction();
                calculateAddressStringFunction.Addr = addr;
                calculateAddressStringFunction.IncludeAddrChecksum = includeAddrChecksum;
            
            return ContractHandler.QueryAsync<CalculateAddressStringFunction, byte[]>(calculateAddressStringFunction, blockParameter);
        }

        public Task<byte[]> CreateClaimMessageQueryAsync(CreateClaimMessageFunction createClaimMessageFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CreateClaimMessageFunction, byte[]>(createClaimMessageFunction, blockParameter);
        }

        
        public Task<byte[]> CreateClaimMessageQueryAsync(string claimToAddr, bool claimAddrChecksum, BlockParameter blockParameter = null)
        {
            var createClaimMessageFunction = new CreateClaimMessageFunction();
                createClaimMessageFunction.ClaimToAddr = claimToAddr;
                createClaimMessageFunction.ClaimAddrChecksum = claimAddrChecksum;
            
            return ContractHandler.QueryAsync<CreateClaimMessageFunction, byte[]>(createClaimMessageFunction, blockParameter);
        }

        public Task<byte[]> GetHashForClaimMessageQueryAsync(GetHashForClaimMessageFunction getHashForClaimMessageFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetHashForClaimMessageFunction, byte[]>(getHashForClaimMessageFunction, blockParameter);
        }

        
        public Task<byte[]> GetHashForClaimMessageQueryAsync(string claimToAddr, bool claimAddrChecksum, BlockParameter blockParameter = null)
        {
            var getHashForClaimMessageFunction = new GetHashForClaimMessageFunction();
                getHashForClaimMessageFunction.ClaimToAddr = claimToAddr;
                getHashForClaimMessageFunction.ClaimAddrChecksum = claimAddrChecksum;
            
            return ContractHandler.QueryAsync<GetHashForClaimMessageFunction, byte[]>(getHashForClaimMessageFunction, blockParameter);
        }

        public Task<string> GetEthAddressFromSignatureQueryAsync(GetEthAddressFromSignatureFunction getEthAddressFromSignatureFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetEthAddressFromSignatureFunction, string>(getEthAddressFromSignatureFunction, blockParameter);
        }

        
        public Task<string> GetEthAddressFromSignatureQueryAsync(string claimToAddr, bool claimAddrChecksum, byte v, byte[] r, byte[] s, BlockParameter blockParameter = null)
        {
            var getEthAddressFromSignatureFunction = new GetEthAddressFromSignatureFunction();
                getEthAddressFromSignatureFunction.ClaimToAddr = claimToAddr;
                getEthAddressFromSignatureFunction.ClaimAddrChecksum = claimAddrChecksum;
                getEthAddressFromSignatureFunction.V = v;
                getEthAddressFromSignatureFunction.R = r;
                getEthAddressFromSignatureFunction.S = s;
            
            return ContractHandler.QueryAsync<GetEthAddressFromSignatureFunction, string>(getEthAddressFromSignatureFunction, blockParameter);
        }

        public Task<bool> ClaimMessageMatchesSignatureQueryAsync(ClaimMessageMatchesSignatureFunction claimMessageMatchesSignatureFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ClaimMessageMatchesSignatureFunction, bool>(claimMessageMatchesSignatureFunction, blockParameter);
        }

        
        public Task<bool> ClaimMessageMatchesSignatureQueryAsync(string claimToAddr, bool claimAddrChecksum, byte[] pubKeyX, byte[] pubKeyY, byte v, byte[] r, byte[] s, BlockParameter blockParameter = null)
        {
            var claimMessageMatchesSignatureFunction = new ClaimMessageMatchesSignatureFunction();
                claimMessageMatchesSignatureFunction.ClaimToAddr = claimToAddr;
                claimMessageMatchesSignatureFunction.ClaimAddrChecksum = claimAddrChecksum;
                claimMessageMatchesSignatureFunction.PubKeyX = pubKeyX;
                claimMessageMatchesSignatureFunction.PubKeyY = pubKeyY;
                claimMessageMatchesSignatureFunction.V = v;
                claimMessageMatchesSignatureFunction.R = r;
                claimMessageMatchesSignatureFunction.S = s;
            
            return ContractHandler.QueryAsync<ClaimMessageMatchesSignatureFunction, bool>(claimMessageMatchesSignatureFunction, blockParameter);
        }
    }
}
