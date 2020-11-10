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
using DMDVision.Contracts.ValidatorSetHbbft.ContractDefinition;

namespace DMDVision.Contracts.ValidatorSetHbbft
{
    public partial class ValidatorSetHbbftService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, ValidatorSetHbbftDeployment validatorSetHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<ValidatorSetHbbftDeployment>().SendRequestAndWaitForReceiptAsync(validatorSetHbbftDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, ValidatorSetHbbftDeployment validatorSetHbbftDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<ValidatorSetHbbftDeployment>().SendRequestAsync(validatorSetHbbftDeployment);
        }

        public static async Task<ValidatorSetHbbftService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, ValidatorSetHbbftDeployment validatorSetHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, validatorSetHbbftDeployment, cancellationTokenSource);
            return new ValidatorSetHbbftService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public ValidatorSetHbbftService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> MAX_VALIDATORSQueryAsync(MAX_VALIDATORSFunction mAX_VALIDATORSFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MAX_VALIDATORSFunction, BigInteger>(mAX_VALIDATORSFunction, blockParameter);
        }

        
        public Task<BigInteger> MAX_VALIDATORSQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MAX_VALIDATORSFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> BanCounterQueryAsync(BanCounterFunction banCounterFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BanCounterFunction, BigInteger>(banCounterFunction, blockParameter);
        }

        
        public Task<BigInteger> BanCounterQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var banCounterFunction = new BanCounterFunction();
                banCounterFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<BanCounterFunction, BigInteger>(banCounterFunction, blockParameter);
        }

        public Task<byte[]> BanReasonQueryAsync(BanReasonFunction banReasonFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BanReasonFunction, byte[]>(banReasonFunction, blockParameter);
        }

        
        public Task<byte[]> BanReasonQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var banReasonFunction = new BanReasonFunction();
                banReasonFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<BanReasonFunction, byte[]>(banReasonFunction, blockParameter);
        }

        public Task<BigInteger> BannedDelegatorsUntilQueryAsync(BannedDelegatorsUntilFunction bannedDelegatorsUntilFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BannedDelegatorsUntilFunction, BigInteger>(bannedDelegatorsUntilFunction, blockParameter);
        }

        
        public Task<BigInteger> BannedDelegatorsUntilQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var bannedDelegatorsUntilFunction = new BannedDelegatorsUntilFunction();
                bannedDelegatorsUntilFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<BannedDelegatorsUntilFunction, BigInteger>(bannedDelegatorsUntilFunction, blockParameter);
        }

        public Task<BigInteger> BannedUntilQueryAsync(BannedUntilFunction bannedUntilFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BannedUntilFunction, BigInteger>(bannedUntilFunction, blockParameter);
        }

        
        public Task<BigInteger> BannedUntilQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var bannedUntilFunction = new BannedUntilFunction();
                bannedUntilFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<BannedUntilFunction, BigInteger>(bannedUntilFunction, blockParameter);
        }

        public Task<string> BlockRewardContractQueryAsync(BlockRewardContractFunction blockRewardContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BlockRewardContractFunction, string>(blockRewardContractFunction, blockParameter);
        }

        
        public Task<string> BlockRewardContractQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BlockRewardContractFunction, string>(null, blockParameter);
        }

        public Task<bool> IsValidatorQueryAsync(IsValidatorFunction isValidatorFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsValidatorFunction, bool>(isValidatorFunction, blockParameter);
        }

        
        public Task<bool> IsValidatorQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var isValidatorFunction = new IsValidatorFunction();
                isValidatorFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<IsValidatorFunction, bool>(isValidatorFunction, blockParameter);
        }

        public Task<bool> IsValidatorPreviousQueryAsync(IsValidatorPreviousFunction isValidatorPreviousFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsValidatorPreviousFunction, bool>(isValidatorPreviousFunction, blockParameter);
        }

        
        public Task<bool> IsValidatorPreviousQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var isValidatorPreviousFunction = new IsValidatorPreviousFunction();
                isValidatorPreviousFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<IsValidatorPreviousFunction, bool>(isValidatorPreviousFunction, blockParameter);
        }

        public Task<string> KeyGenHistoryContractQueryAsync(KeyGenHistoryContractFunction keyGenHistoryContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<KeyGenHistoryContractFunction, string>(keyGenHistoryContractFunction, blockParameter);
        }

        
        public Task<string> KeyGenHistoryContractQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<KeyGenHistoryContractFunction, string>(null, blockParameter);
        }

        public Task<string> MiningByStakingAddressQueryAsync(MiningByStakingAddressFunction miningByStakingAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MiningByStakingAddressFunction, string>(miningByStakingAddressFunction, blockParameter);
        }

        
        public Task<string> MiningByStakingAddressQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var miningByStakingAddressFunction = new MiningByStakingAddressFunction();
                miningByStakingAddressFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<MiningByStakingAddressFunction, string>(miningByStakingAddressFunction, blockParameter);
        }

        public Task<string> RandomContractQueryAsync(RandomContractFunction randomContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<RandomContractFunction, string>(randomContractFunction, blockParameter);
        }

        
        public Task<string> RandomContractQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<RandomContractFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> ReportingCounterQueryAsync(ReportingCounterFunction reportingCounterFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ReportingCounterFunction, BigInteger>(reportingCounterFunction, blockParameter);
        }

        
        public Task<BigInteger> ReportingCounterQueryAsync(string returnValue1, BigInteger returnValue2, BlockParameter blockParameter = null)
        {
            var reportingCounterFunction = new ReportingCounterFunction();
                reportingCounterFunction.ReturnValue1 = returnValue1;
                reportingCounterFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<ReportingCounterFunction, BigInteger>(reportingCounterFunction, blockParameter);
        }

        public Task<BigInteger> ReportingCounterTotalQueryAsync(ReportingCounterTotalFunction reportingCounterTotalFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ReportingCounterTotalFunction, BigInteger>(reportingCounterTotalFunction, blockParameter);
        }

        
        public Task<BigInteger> ReportingCounterTotalQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var reportingCounterTotalFunction = new ReportingCounterTotalFunction();
                reportingCounterTotalFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<ReportingCounterTotalFunction, BigInteger>(reportingCounterTotalFunction, blockParameter);
        }

        public Task<string> StakingByMiningAddressQueryAsync(StakingByMiningAddressFunction stakingByMiningAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingByMiningAddressFunction, string>(stakingByMiningAddressFunction, blockParameter);
        }

        
        public Task<string> StakingByMiningAddressQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var stakingByMiningAddressFunction = new StakingByMiningAddressFunction();
                stakingByMiningAddressFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<StakingByMiningAddressFunction, string>(stakingByMiningAddressFunction, blockParameter);
        }

        public Task<string> StakingContractQueryAsync(StakingContractFunction stakingContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingContractFunction, string>(stakingContractFunction, blockParameter);
        }

        
        public Task<string> StakingContractQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingContractFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> ValidatorCounterQueryAsync(ValidatorCounterFunction validatorCounterFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidatorCounterFunction, BigInteger>(validatorCounterFunction, blockParameter);
        }

        
        public Task<BigInteger> ValidatorCounterQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var validatorCounterFunction = new ValidatorCounterFunction();
                validatorCounterFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<ValidatorCounterFunction, BigInteger>(validatorCounterFunction, blockParameter);
        }

        public Task<BigInteger> GetCurrentTimestampQueryAsync(GetCurrentTimestampFunction getCurrentTimestampFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetCurrentTimestampFunction, BigInteger>(getCurrentTimestampFunction, blockParameter);
        }

        
        public Task<BigInteger> GetCurrentTimestampQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetCurrentTimestampFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> InitializeRequestAsync(InitializeFunction initializeFunction)
        {
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(InitializeFunction initializeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> InitializeRequestAsync(string blockRewardContract, string randomContract, string stakingContract, string keyGenHistoryContract, List<string> initialMiningAddresses, List<string> initialStakingAddresses)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.BlockRewardContract = blockRewardContract;
                initializeFunction.RandomContract = randomContract;
                initializeFunction.StakingContract = stakingContract;
                initializeFunction.KeyGenHistoryContract = keyGenHistoryContract;
                initializeFunction.InitialMiningAddresses = initialMiningAddresses;
                initializeFunction.InitialStakingAddresses = initialStakingAddresses;
            
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(string blockRewardContract, string randomContract, string stakingContract, string keyGenHistoryContract, List<string> initialMiningAddresses, List<string> initialStakingAddresses, CancellationTokenSource cancellationToken = null)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.BlockRewardContract = blockRewardContract;
                initializeFunction.RandomContract = randomContract;
                initializeFunction.StakingContract = stakingContract;
                initializeFunction.KeyGenHistoryContract = keyGenHistoryContract;
                initializeFunction.InitialMiningAddresses = initialMiningAddresses;
                initializeFunction.InitialStakingAddresses = initialStakingAddresses;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> FinalizeChangeRequestAsync(FinalizeChangeFunction finalizeChangeFunction)
        {
             return ContractHandler.SendRequestAsync(finalizeChangeFunction);
        }

        public Task<string> FinalizeChangeRequestAsync()
        {
             return ContractHandler.SendRequestAsync<FinalizeChangeFunction>();
        }

        public Task<TransactionReceipt> FinalizeChangeRequestAndWaitForReceiptAsync(FinalizeChangeFunction finalizeChangeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(finalizeChangeFunction, cancellationToken);
        }

        public Task<TransactionReceipt> FinalizeChangeRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<FinalizeChangeFunction>(null, cancellationToken);
        }

        public Task<string> NewValidatorSetRequestAsync(NewValidatorSetFunction newValidatorSetFunction)
        {
             return ContractHandler.SendRequestAsync(newValidatorSetFunction);
        }

        public Task<string> NewValidatorSetRequestAsync()
        {
             return ContractHandler.SendRequestAsync<NewValidatorSetFunction>();
        }

        public Task<TransactionReceipt> NewValidatorSetRequestAndWaitForReceiptAsync(NewValidatorSetFunction newValidatorSetFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(newValidatorSetFunction, cancellationToken);
        }

        public Task<TransactionReceipt> NewValidatorSetRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<NewValidatorSetFunction>(null, cancellationToken);
        }

        public Task<string> RemoveMaliciousValidatorsRequestAsync(RemoveMaliciousValidatorsFunction removeMaliciousValidatorsFunction)
        {
             return ContractHandler.SendRequestAsync(removeMaliciousValidatorsFunction);
        }

        public Task<TransactionReceipt> RemoveMaliciousValidatorsRequestAndWaitForReceiptAsync(RemoveMaliciousValidatorsFunction removeMaliciousValidatorsFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeMaliciousValidatorsFunction, cancellationToken);
        }

        public Task<string> RemoveMaliciousValidatorsRequestAsync(List<string> miningAddresses)
        {
            var removeMaliciousValidatorsFunction = new RemoveMaliciousValidatorsFunction();
                removeMaliciousValidatorsFunction.MiningAddresses = miningAddresses;
            
             return ContractHandler.SendRequestAsync(removeMaliciousValidatorsFunction);
        }

        public Task<TransactionReceipt> RemoveMaliciousValidatorsRequestAndWaitForReceiptAsync(List<string> miningAddresses, CancellationTokenSource cancellationToken = null)
        {
            var removeMaliciousValidatorsFunction = new RemoveMaliciousValidatorsFunction();
                removeMaliciousValidatorsFunction.MiningAddresses = miningAddresses;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeMaliciousValidatorsFunction, cancellationToken);
        }

        public Task<string> ReportMaliciousRequestAsync(ReportMaliciousFunction reportMaliciousFunction)
        {
             return ContractHandler.SendRequestAsync(reportMaliciousFunction);
        }

        public Task<TransactionReceipt> ReportMaliciousRequestAndWaitForReceiptAsync(ReportMaliciousFunction reportMaliciousFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(reportMaliciousFunction, cancellationToken);
        }

        public Task<string> ReportMaliciousRequestAsync(string maliciousMiningAddress, BigInteger blockNumber)
        {
            var reportMaliciousFunction = new ReportMaliciousFunction();
                reportMaliciousFunction.MaliciousMiningAddress = maliciousMiningAddress;
                reportMaliciousFunction.BlockNumber = blockNumber;
            
             return ContractHandler.SendRequestAsync(reportMaliciousFunction);
        }

        public Task<TransactionReceipt> ReportMaliciousRequestAndWaitForReceiptAsync(string maliciousMiningAddress, BigInteger blockNumber, CancellationTokenSource cancellationToken = null)
        {
            var reportMaliciousFunction = new ReportMaliciousFunction();
                reportMaliciousFunction.MaliciousMiningAddress = maliciousMiningAddress;
                reportMaliciousFunction.BlockNumber = blockNumber;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(reportMaliciousFunction, cancellationToken);
        }

        public Task<string> SetStakingAddressRequestAsync(SetStakingAddressFunction setStakingAddressFunction)
        {
             return ContractHandler.SendRequestAsync(setStakingAddressFunction);
        }

        public Task<TransactionReceipt> SetStakingAddressRequestAndWaitForReceiptAsync(SetStakingAddressFunction setStakingAddressFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStakingAddressFunction, cancellationToken);
        }

        public Task<string> SetStakingAddressRequestAsync(string miningAddress, string stakingAddress)
        {
            var setStakingAddressFunction = new SetStakingAddressFunction();
                setStakingAddressFunction.MiningAddress = miningAddress;
                setStakingAddressFunction.StakingAddress = stakingAddress;
            
             return ContractHandler.SendRequestAsync(setStakingAddressFunction);
        }

        public Task<TransactionReceipt> SetStakingAddressRequestAndWaitForReceiptAsync(string miningAddress, string stakingAddress, CancellationTokenSource cancellationToken = null)
        {
            var setStakingAddressFunction = new SetStakingAddressFunction();
                setStakingAddressFunction.MiningAddress = miningAddress;
                setStakingAddressFunction.StakingAddress = stakingAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStakingAddressFunction, cancellationToken);
        }

        public Task<bool> AreDelegatorsBannedQueryAsync(AreDelegatorsBannedFunction areDelegatorsBannedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AreDelegatorsBannedFunction, bool>(areDelegatorsBannedFunction, blockParameter);
        }

        
        public Task<bool> AreDelegatorsBannedQueryAsync(string miningAddress, BlockParameter blockParameter = null)
        {
            var areDelegatorsBannedFunction = new AreDelegatorsBannedFunction();
                areDelegatorsBannedFunction.MiningAddress = miningAddress;
            
            return ContractHandler.QueryAsync<AreDelegatorsBannedFunction, bool>(areDelegatorsBannedFunction, blockParameter);
        }

        public Task<List<string>> GetPreviousValidatorsQueryAsync(GetPreviousValidatorsFunction getPreviousValidatorsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPreviousValidatorsFunction, List<string>>(getPreviousValidatorsFunction, blockParameter);
        }

        
        public Task<List<string>> GetPreviousValidatorsQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPreviousValidatorsFunction, List<string>>(null, blockParameter);
        }

        public Task<List<string>> GetPendingValidatorsQueryAsync(GetPendingValidatorsFunction getPendingValidatorsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPendingValidatorsFunction, List<string>>(getPendingValidatorsFunction, blockParameter);
        }

        
        public Task<List<string>> GetPendingValidatorsQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPendingValidatorsFunction, List<string>>(null, blockParameter);
        }

        public Task<List<string>> GetValidatorsQueryAsync(GetValidatorsFunction getValidatorsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetValidatorsFunction, List<string>>(getValidatorsFunction, blockParameter);
        }

        
        public Task<List<string>> GetValidatorsQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetValidatorsFunction, List<string>>(null, blockParameter);
        }

        public Task<bool> IsInitializedQueryAsync(IsInitializedFunction isInitializedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsInitializedFunction, bool>(isInitializedFunction, blockParameter);
        }

        
        public Task<bool> IsInitializedQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsInitializedFunction, bool>(null, blockParameter);
        }

        public Task<bool> IsReportValidatorValidQueryAsync(IsReportValidatorValidFunction isReportValidatorValidFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsReportValidatorValidFunction, bool>(isReportValidatorValidFunction, blockParameter);
        }

        
        public Task<bool> IsReportValidatorValidQueryAsync(string miningAddress, BlockParameter blockParameter = null)
        {
            var isReportValidatorValidFunction = new IsReportValidatorValidFunction();
                isReportValidatorValidFunction.MiningAddress = miningAddress;
            
            return ContractHandler.QueryAsync<IsReportValidatorValidFunction, bool>(isReportValidatorValidFunction, blockParameter);
        }

        public Task<bool> IsValidatorBannedQueryAsync(IsValidatorBannedFunction isValidatorBannedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsValidatorBannedFunction, bool>(isValidatorBannedFunction, blockParameter);
        }

        
        public Task<bool> IsValidatorBannedQueryAsync(string miningAddress, BlockParameter blockParameter = null)
        {
            var isValidatorBannedFunction = new IsValidatorBannedFunction();
                isValidatorBannedFunction.MiningAddress = miningAddress;
            
            return ContractHandler.QueryAsync<IsValidatorBannedFunction, bool>(isValidatorBannedFunction, blockParameter);
        }

        public Task<bool> IsValidatorOrPendingQueryAsync(IsValidatorOrPendingFunction isValidatorOrPendingFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsValidatorOrPendingFunction, bool>(isValidatorOrPendingFunction, blockParameter);
        }

        
        public Task<bool> IsValidatorOrPendingQueryAsync(string miningAddress, BlockParameter blockParameter = null)
        {
            var isValidatorOrPendingFunction = new IsValidatorOrPendingFunction();
                isValidatorOrPendingFunction.MiningAddress = miningAddress;
            
            return ContractHandler.QueryAsync<IsValidatorOrPendingFunction, bool>(isValidatorOrPendingFunction, blockParameter);
        }

        public Task<bool> IsPendingValidatorQueryAsync(IsPendingValidatorFunction isPendingValidatorFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsPendingValidatorFunction, bool>(isPendingValidatorFunction, blockParameter);
        }

        
        public Task<bool> IsPendingValidatorQueryAsync(string miningAddress, BlockParameter blockParameter = null)
        {
            var isPendingValidatorFunction = new IsPendingValidatorFunction();
                isPendingValidatorFunction.MiningAddress = miningAddress;
            
            return ContractHandler.QueryAsync<IsPendingValidatorFunction, bool>(isPendingValidatorFunction, blockParameter);
        }

        public Task<List<string>> MaliceReportedForBlockQueryAsync(MaliceReportedForBlockFunction maliceReportedForBlockFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaliceReportedForBlockFunction, List<string>>(maliceReportedForBlockFunction, blockParameter);
        }

        
        public Task<List<string>> MaliceReportedForBlockQueryAsync(string miningAddress, BigInteger blockNumber, BlockParameter blockParameter = null)
        {
            var maliceReportedForBlockFunction = new MaliceReportedForBlockFunction();
                maliceReportedForBlockFunction.MiningAddress = miningAddress;
                maliceReportedForBlockFunction.BlockNumber = blockNumber;
            
            return ContractHandler.QueryAsync<MaliceReportedForBlockFunction, List<string>>(maliceReportedForBlockFunction, blockParameter);
        }

        public Task<ReportMaliciousCallableOutputDTO> ReportMaliciousCallableQueryAsync(ReportMaliciousCallableFunction reportMaliciousCallableFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<ReportMaliciousCallableFunction, ReportMaliciousCallableOutputDTO>(reportMaliciousCallableFunction, blockParameter);
        }

        public Task<ReportMaliciousCallableOutputDTO> ReportMaliciousCallableQueryAsync(string reportingMiningAddress, string maliciousMiningAddress, BigInteger blockNumber, BlockParameter blockParameter = null)
        {
            var reportMaliciousCallableFunction = new ReportMaliciousCallableFunction();
                reportMaliciousCallableFunction.ReportingMiningAddress = reportingMiningAddress;
                reportMaliciousCallableFunction.MaliciousMiningAddress = maliciousMiningAddress;
                reportMaliciousCallableFunction.BlockNumber = blockNumber;
            
            return ContractHandler.QueryDeserializingToObjectAsync<ReportMaliciousCallableFunction, ReportMaliciousCallableOutputDTO>(reportMaliciousCallableFunction, blockParameter);
        }

        public Task<byte[]> PublicKeyByStakingAddressQueryAsync(PublicKeyByStakingAddressFunction publicKeyByStakingAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PublicKeyByStakingAddressFunction, byte[]>(publicKeyByStakingAddressFunction, blockParameter);
        }

        
        public Task<byte[]> PublicKeyByStakingAddressQueryAsync(string stakingAddress, BlockParameter blockParameter = null)
        {
            var publicKeyByStakingAddressFunction = new PublicKeyByStakingAddressFunction();
                publicKeyByStakingAddressFunction.StakingAddress = stakingAddress;
            
            return ContractHandler.QueryAsync<PublicKeyByStakingAddressFunction, byte[]>(publicKeyByStakingAddressFunction, blockParameter);
        }

        public Task<byte[]> GetPublicKeyQueryAsync(GetPublicKeyFunction getPublicKeyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPublicKeyFunction, byte[]>(getPublicKeyFunction, blockParameter);
        }

        
        public Task<byte[]> GetPublicKeyQueryAsync(string miningAddress, BlockParameter blockParameter = null)
        {
            var getPublicKeyFunction = new GetPublicKeyFunction();
                getPublicKeyFunction.MiningAddress = miningAddress;
            
            return ContractHandler.QueryAsync<GetPublicKeyFunction, byte[]>(getPublicKeyFunction, blockParameter);
        }
    }
}
